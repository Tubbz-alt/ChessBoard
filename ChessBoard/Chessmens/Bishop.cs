﻿using System;
using System.Collections.Generic;

namespace ChessBoard.Chessmens
{
	public class Bishop : BaseChessman
	{
		public override ChessmenType Type => ChessmenType.Bishop;

		public Bishop()
		{ }

		public Bishop(Color color) : base(color)
		{ }

		public override bool Equals(object obj)
		{
			if (!(obj is Bishop))
				return false;

			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();	
		}

		public override List<Cell> GetAcceptableCells(
			BoardCell[,] boardCells, 
			Cell currentCell, 
			bool needToCheckShah = true)
		{
			Direction[] possibleDirections =
			{
				new Direction {Row = -1, Column = -1},
				new Direction {Row = -1, Column = 1},
				new Direction {Row = 1, Column = -1},
				new Direction {Row = 1, Column = 1}
			};

			var acceptableCells = GetAcceptableCellsForDirections(boardCells, possibleDirections, currentCell);

			if (needToCheckShah)
				AdjustAcceptableCellsInCaseShah(boardCells, acceptableCells, currentCell);

			return acceptableCells;
		}
	}
}
