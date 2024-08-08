﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Game.Const
{
	/// <summary>
	/// Types of returns for a storage operation
	/// </summary>
	public enum StorageResult
	{
		Success = 0,
		ItemNotFound = 1,
		InvalidOperation = 2,
		StorageFull = 3,
	}
}
