﻿using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.World;
using Melia.Shared.Game.Const;
using g3;
using Yggdrasil.Util;

namespace Melia.Zone.World.Maps
{
	public class Pathfinder
	{
		private readonly Dictionary<SizeType, float> _entitySizeRadius = new Dictionary<SizeType, float>
		{
			{ SizeType.None, 0 },
			{ SizeType.Hidden, 0 },
			{ SizeType.S, 12 },
			{ SizeType.M, 15 },
			{ SizeType.L, 20 },
			{ SizeType.XL, 40 },
			{ SizeType.XXL, 40 }
		};

		private Ground _ground;

		/// <summary>
		/// Finds a path from start position to the goal position using
		/// A* algorithm. Returns List of valid positions to goal.
		/// Last element is always the goal.
		/// Returns empty list if no path can be found.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="goal"></param>
		/// <param name="entitySize"></param>
		/// <returns></returns>
		public List<Position> FindPath(Position start, Position goal, SizeType entitySize = SizeType.M)
		{
			var scale = (int)_entitySizeRadius[entitySize] * 2;
			return this.FindPathScale(start, goal, scale, entitySize);
		}

		/// <summary>
		/// Finds a path from start position to the goal position using
		/// A* algorithm and a path node scale.
		/// Returns empty list if no path can be found.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="goal"></param>
		/// <param name="scale"></param>
		/// <param name="entitySize"></param>
		/// <returns></returns>
		private List<Position> FindPathScale(Position start, Position goal, int scale, SizeType entitySize = SizeType.M)
		{
			var path = new List<Position>();
			var openSet = new PriorityQueue<Position, float>();
			var cameFrom = new Dictionary<Position, Position>();
			var gScore = new Dictionary<Position, float> { [start] = 0 };
			var fScore = new Dictionary<Position, float> { [start] = this.Heuristic(start, goal) };
			var radius = _entitySizeRadius[entitySize];

			// Stopping condition
			if (scale <= 0)
				return path;

			// Stopping condition
			if (start.Get2DDistance(goal) < radius)
			{
				path.Add(goal);
				return path;
			}

			// Start A*
			openSet.Enqueue(start, fScore[start]);
			while (openSet.Count > 0)
			{
				var current = openSet.Dequeue();

				// Check if we need to improve our search
				if (current.Get2DDistance(goal) < scale)
				{
					path.AddRange(this.ReconstructPath(cameFrom, current, entitySize));
					path.Add(goal); // Add the goal to the path
					return path;
				}

				// Compute neighbors
				var neighbors = this.GetNeighbors(current, entitySize, scale);
				foreach (var neighbor in neighbors)
				{
					var tentativeGScore = gScore[current] + scale;

					if (!gScore.ContainsKey(neighbor) || tentativeGScore < gScore[neighbor])
					{
						cameFrom[neighbor] = current;
						gScore[neighbor] = tentativeGScore;
						fScore[neighbor] = gScore[neighbor] + this.Heuristic(neighbor, goal) + RandomProvider.Next(scale);

						if (!openSet.UnorderedItems.Any(item => item.Element.Equals(neighbor)))
						{
							openSet.Enqueue(neighbor, fScore[neighbor]);
						}
					}
				}
			}

			// No path found
			return path;
		}

		/// <summary>
		/// Compares two float and position tuples.
		/// </summary>
		private class PositionComparer : IComparer<(float F, Position Pos)>
		{
			public int Compare((float F, Position Pos) p1, (float F, Position Pos) p2)
			{
				var result = p1.F.CompareTo(p2.F);
				if (result == 0)
				{
					// Ignore Y coord
					result = p1.Pos.X.CompareTo(p2.Pos.X);
					if (result == 0)
					{
						result = p1.Pos.Z.CompareTo(p2.Pos.Z);
					}
				}
				return result;
			}
		}

		/// <summary>
		/// Reconstructs the path from the given position,
		/// merging nodes together if there are no obstacles between them
		/// considering the entity size.
		/// </summary>
		/// <param name="cameFrom"></param>
		/// <param name="position"></param>
		/// <param name="entitySize"></param>
		/// <returns></returns>
		private List<Position> ReconstructPath(Dictionary<Position, Position> cameFrom, Position position, SizeType entitySize)
		{
			var radius = _entitySizeRadius[entitySize];
			var totalPath = new List<Position>();
			totalPath.Add(position);

			while (cameFrom.ContainsKey(position))
			{
				var nextNode = cameFrom[position];

				position = nextNode;
				totalPath.Add(position);
			}

			totalPath.Reverse();
			return totalPath;
		}

		/// <summary>
		/// Calculates the heuristic cost from position a to position b.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		private float Heuristic(Position a, Position b)
		{
			// Euclidean Distance
			var dx = Math.Abs(a.X - b.X);
			var dy = Math.Abs(a.Y - b.Y);
			var dz = Math.Abs(a.Z - b.Z);
			return (float)Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy,2) + Math.Pow(dz, 2));
		}

		/// <summary>
		/// Gets the neighboring positions for a given position under a given
		/// grid scale.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="entitySize"></param>
		/// <param name="gridScale"></param>
		/// <returns>A list of neighboring positions.</returns>
		private List<Position> GetNeighbors(Position pos, SizeType entitySize, int gridScale)
		{
			// Scale is too low
			if (gridScale <= 0)
				return new List<Position>();

			var radius = _entitySizeRadius[entitySize];
			var neighbors = new List<Position>();
			var d = gridScale;
			var directions = new (int X, int Z)[] { (-d, 0), (d, 0), (0, -d), (0, d), (-d, d), (-d, -d), (d, -d), (d, d) };

			// Search in all adjacent directions
			foreach (var dir in directions)
			{
				var neighbor = new Position(pos.X + dir.X, 0, pos.Z + dir.Z);

				// Position at neighbor is valid
				if (_ground.TryGetHeightAt(neighbor, out var height))
				{
					// Our entity can stand there
					if (_ground.IsValidCirclePosition(neighbor, radius))
					{
						neighbor.Y = height;
						neighbors.Add(neighbor);
					}
				}
			}

			// No adjacent neighbors found
			if (neighbors.Count == 0)
			{
				// Try again recursively with lower scale
				return this.GetNeighbors(pos, entitySize, gridScale/2);
			}

			// Shuffle our neighbors
			return neighbors;
		}
	}
}