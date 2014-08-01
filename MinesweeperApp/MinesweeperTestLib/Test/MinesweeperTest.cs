using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MinesweeperLib;

namespace MinesweeperTestLib
{
    [TestFixture]
    public class MinesweeperTest
    {
        Minesweeper _minesweeper;

        [SetUp]
        public void createMinesweeper()
        {
            _minesweeper = new Minesweeper();
        }

        [Test]
        public void testCanary()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void testExposeCell()
        {
            Assert.IsTrue(_minesweeper.ExposeCell(1, 2));
        }

        [Test]
        public void testSealACell()
        {
            Assert.IsTrue(_minesweeper.SealACell(2, 5));
        }

        [Test]
        public void testUnsealACell()
        {
            _minesweeper.SealACell(1, 2);
            Assert.IsTrue(_minesweeper.UnsealACell(1, 2));
        }

        [Test]
        public void testSealAnExposedCell()
        {
            _minesweeper.ExposeCell(1, 2);
            Assert.IsFalse(_minesweeper.SealACell(1, 2));
        }

        [Test]
        public void testIsGameOverOnCreate()
        {
            Assert.IsFalse(_minesweeper.IsGameOver());
        }

        [Test]
        public void testSealASealedCell()
        {
            _minesweeper.SealACell(1, 2);
            Assert.IsFalse(_minesweeper.SealACell(1, 2));
        }

        [Test]
        public void testUnsealAUnsealCell()
        {
            Assert.IsFalse(_minesweeper.UnsealACell(1, 2));
        }

        [Test]
        public void testExposeAnExposedCell()
        {
            _minesweeper.ExposeCell(1, 2);
            Assert.IsFalse(_minesweeper.ExposeCell(1, 2));
        }

        [Test]
        public void testExposeASealedCell()
        {
            _minesweeper.SealACell(1, 2);
            Assert.IsFalse(_minesweeper.ExposeCell(1, 2));
        }

        [Test]
        public void testGameLostIfAMineExposed()
        {
            _minesweeper.SetMine(3, 4);
            _minesweeper.ExposeCell(3, 4);
            Assert.IsTrue(_minesweeper.IsGameOver());
        }

        [Test]
        public void testGetAdjacentCellCountIfNoNeighborMines()
        {
            Assert.AreEqual(0, _minesweeper.GetAdjacentCellCount(1, 2));
        }

        [Test]
        public void testGetAdjacentCellCountIfOneNeighborMines()
        {
            _minesweeper.SetMine(0, 0);
            Assert.AreEqual(1, _minesweeper.GetAdjacentCellCount(1, 1));
        }

        [Test]
        public void testGetAdjacentCellCountIfTwoNeighborMines()
        {
            _minesweeper.SetMine(0, 0);
            _minesweeper.SetMine(0, 1);
            Assert.AreEqual(2, _minesweeper.GetAdjacentCellCount(1, 1));
        }

        [Test]
        public void testGetAdjacentCellCountIfThreeNeighborMines()
        {
            _minesweeper.SetMine(0, 0);
            _minesweeper.SetMine(0, 1);
            _minesweeper.SetMine(0, 2);
            Assert.AreEqual(3, _minesweeper.GetAdjacentCellCount(1, 1));
        }

        [Test]
        public void testGetAdjacentCellCountIfFourNeighborMines()
        {
            _minesweeper.SetMine(0, 0);
            _minesweeper.SetMine(0, 1);
            _minesweeper.SetMine(0, 2);
            _minesweeper.SetMine(1, 0);
            Assert.AreEqual(4, _minesweeper.GetAdjacentCellCount(1, 1));
        }

        [Test]
        public void testGetAdjacentCellCountIfFiveNeighborMines()
        {
            _minesweeper.SetMine(0, 0);
            _minesweeper.SetMine(0, 1);
            _minesweeper.SetMine(0, 2);
            _minesweeper.SetMine(1, 0);
            _minesweeper.SetMine(1, 2);
            Assert.AreEqual(5, _minesweeper.GetAdjacentCellCount(1, 1));
        }

        [Test]
        public void testGetAdjacentCellCountIfSixNeighborMines()
        {
            _minesweeper.SetMine(0, 0);
            _minesweeper.SetMine(0, 1);
            _minesweeper.SetMine(0, 2);
            _minesweeper.SetMine(1, 0);
            _minesweeper.SetMine(1, 2);
            _minesweeper.SetMine(2, 0);
            Assert.AreEqual(6, _minesweeper.GetAdjacentCellCount(1, 1));
        }

        [Test]
        public void testGetAdjacentCellCountIfSevenNeighborMines()
        {
            _minesweeper.SetMine(0, 0);
            _minesweeper.SetMine(0, 1);
            _minesweeper.SetMine(0, 2);
            _minesweeper.SetMine(1, 0);
            _minesweeper.SetMine(1, 2);
            _minesweeper.SetMine(2, 0);
            _minesweeper.SetMine(2, 1);
            Assert.AreEqual(7, _minesweeper.GetAdjacentCellCount(1, 1));
        }

        [Test]
        public void testGetAdjacentCellCountIfEightNeighborMines()
        {
            _minesweeper.SetMine(0, 0);
            _minesweeper.SetMine(0, 1);
            _minesweeper.SetMine(0, 2);
            _minesweeper.SetMine(1, 0);
            _minesweeper.SetMine(1, 2);
            _minesweeper.SetMine(2, 0);
            _minesweeper.SetMine(2, 1);
            _minesweeper.SetMine(2, 2);
            Assert.AreEqual(8, _minesweeper.GetAdjacentCellCount(1, 1));
        }

        [Test]
        public void testGetAdjacentCellCountForCornerCell()
        {
            _minesweeper.SetMine(0, 1);
            _minesweeper.SetMine(1, 0);
            _minesweeper.SetMine(1, 1);
            Assert.AreEqual(3, _minesweeper.GetAdjacentCellCount(0, 0));
        }

        [Test]
        public void testExposeNeighboringEmptyCellsAfterAnEmptyCellIsExposed()
        {
            _minesweeper.ExposeCell(5, 5);
            _minesweeper.ExposeNeighboringCells(5, 5);
            for (int i = 4; i <= 6; i++)
                for (int j = 4; j <= 6; j++)
                {
                    Assert.False(_minesweeper.ExposeCell(i, j));
                }
        }

        [Test]
        public void testExposeNeigbhorOfNeighboringEmptyCellsAfterAnEmptyCellIsExposed()
        {
            _minesweeper.ExposeCell(5, 5);
            _minesweeper.ExposeNeighboringCells(5, 5);
            Assert.IsFalse(_minesweeper.ExposeCell(3, 4));
        }

        [Test]
        public void testExposeAdjacentCellNeighborToAnExposedEmptyCell()
        {
            _minesweeper.SetMine(3, 4);
            _minesweeper.ExposeCell(5, 5);
            _minesweeper.ExposeNeighboringCells(5, 5);
            Assert.IsFalse(_minesweeper.ExposeCell(4, 4));
        }

        [Test]
        public void testExposeNeighboringCellsOfExposedAdjacentCell()
        {
            _minesweeper.SetMine(3, 4);
            _minesweeper.ExposeCell(4, 4);
            Assert.IsFalse(_minesweeper.ExposeNeighboringCells(4, 4));
        }

        [Test]
        public void testDisplayAdjacentCellCountWithOneMinesAfterExposeACell()
        {
            _minesweeper.SetMine(2, 2);
            _minesweeper.ExposeCell(1, 2);
            Assert.AreEqual('1', _minesweeper.DisplayOnCell(1, 2));
        }

        [Test]
        public void testDisplayAdjacentCellCountWithTwoMinesAfterExposeACell()
        {
            _minesweeper.SetMine(1, 1);
            _minesweeper.SetMine(1, 2);
            _minesweeper.ExposeCell(2, 2);
            Assert.AreEqual('2', _minesweeper.DisplayOnCell(2, 2));
        }

        [Test]
        public void testDisplayAdjacentCellCountWithThreeMinesAfterExposeACell()
        {
            _minesweeper.SetMine(1, 1);
            _minesweeper.SetMine(1, 2);
            _minesweeper.SetMine(2, 1);
            _minesweeper.ExposeCell(2, 2);
            Assert.AreEqual('3', _minesweeper.DisplayOnCell(2, 2));
        }

        [Test]
        public void testDisplayAdjacentCellCountWithFourMinesAfterExposeACell()
        {
            _minesweeper.SetMine(1, 1);
            _minesweeper.SetMine(1, 2);
            _minesweeper.SetMine(2, 1);
            _minesweeper.SetMine(3, 1);
            _minesweeper.ExposeCell(2, 2);
            Assert.AreEqual('4', _minesweeper.DisplayOnCell(2, 2));
        }

        [Test]
        public void testDisplayAdjacentCellCountWithFiveMinesAfterExposeACell()
        {
            _minesweeper.SetMine(1, 1);
            _minesweeper.SetMine(1, 2);
            _minesweeper.SetMine(2, 1);
            _minesweeper.SetMine(3, 1);
            _minesweeper.SetMine(3, 2);
            _minesweeper.ExposeCell(2, 2);
            Assert.AreEqual('5', _minesweeper.DisplayOnCell(2, 2));
        }

        [Test]
        public void testDisplayAdjacentCellCountWithSixMinesAfterExposeACell()
        {
            _minesweeper.SetMine(1, 1);
            _minesweeper.SetMine(1, 2);
            _minesweeper.SetMine(2, 1);
            _minesweeper.SetMine(3, 1);
            _minesweeper.SetMine(3, 2);
            _minesweeper.SetMine(3, 3);
            _minesweeper.ExposeCell(2, 2);
            Assert.AreEqual('6', _minesweeper.DisplayOnCell(2, 2));
        }

        [Test]
        public void testDisplayAdjacentCellCountWithSevenMinesAfterExposeACell()
        {
            _minesweeper.SetMine(1, 1);
            _minesweeper.SetMine(1, 2);
            _minesweeper.SetMine(2, 1);
            _minesweeper.SetMine(2, 3);
            _minesweeper.SetMine(3, 1);
            _minesweeper.SetMine(3, 2);
            _minesweeper.SetMine(3, 3);
            _minesweeper.ExposeCell(2, 2);
            Assert.AreEqual('7', _minesweeper.DisplayOnCell(2, 2));
        }

        [Test]
        public void testDisplayAdjacentCellCountWithEightMinesAfterExposeACell()
        {
            _minesweeper.SetMine(1, 1);
            _minesweeper.SetMine(1, 2);
            _minesweeper.SetMine(1, 3);
            _minesweeper.SetMine(2, 1);
            _minesweeper.SetMine(2, 3);
            _minesweeper.SetMine(3, 1);
            _minesweeper.SetMine(3, 2);
            _minesweeper.SetMine(3, 3);
            _minesweeper.ExposeCell(2, 2);
            Assert.AreEqual('8', _minesweeper.DisplayOnCell(2, 2));
        }

        [Test]
        public void testDisplaySealAfterSealACelll()
        {
            _minesweeper.SealACell(2, 2);
            Assert.AreEqual('S', _minesweeper.DisplayOnCell(2, 2));
        }
        [Test]
        public void testDisplayMineOnCellAfterExpose()
        {
            _minesweeper.SetMine(2, 2);
            _minesweeper.ExposeCell(2, 2);
            Assert.AreEqual('M', _minesweeper.DisplayOnCell(2, 2));
        }

        [Test]
        public void testDisplayEmptyCellAfterExpose()
        {
            _minesweeper.ExposeCell(2, 3);
            Assert.AreEqual(' ', _minesweeper.DisplayOnCell(2, 3));
        }

        [Test]
        public void testDisplayUnsealedCell()
        {
            Assert.AreEqual('U', _minesweeper.DisplayOnCell(2, 9));
        }

        [Test]
        public void testDisplayUnsealSealedCell()
        {
            _minesweeper.SealACell(1, 2);
            _minesweeper.UnsealACell(1, 2);
            Assert.AreEqual('U', _minesweeper.DisplayOnCell(1, 2));
        }

        [Test]
        public void testDisplayNeighboringAdjacentCellsAfterExposeEmptyCell()
        {
            _minesweeper.SetMine(2, 6);
            _minesweeper.SetMine(4, 6);
            _minesweeper.ExposeCell(2, 4);
            _minesweeper.ExposeNeighboringCells(2, 4);
            Assert.AreEqual('1', _minesweeper.DisplayOnCell(2, 5));
        }

        [Test]
        public void testNumberOfMinesPlacedIsTen()
        {
            int count = 0;
            _minesweeper.PlaceMines();

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (_minesweeper.mineGrid[i, j])
                        count++;
                }
            Assert.AreEqual(10, count);
        }

        [Test]
        public void testPlaceMinesForFirstTime()
        {
            _minesweeper.PlaceMines();
            Minesweeper minesweeper2 = new Minesweeper();
            minesweeper2.PlaceMines();
            Assert.IsFalse(_minesweeper.mineGrid.Equals(minesweeper2.mineGrid));
        }

        [Test]
        public void testGamewinOnExposingMinedCells()
        {
            _minesweeper.SetMine(2, 3);
            _minesweeper.ExposeCell(2, 3);
            Assert.IsFalse(_minesweeper.CheckGameWin());

        }

        [Test]
        public void testGamewinOnSealingdMineCell()
        {
            _minesweeper.SetMine(1, 2);
            _minesweeper.SealACell(1, 2);
            Assert.IsFalse(_minesweeper.CheckGameWin());
        }

        [Test]
        public void testGameWinOnSealingAllMineCells()
        {
            _minesweeper.PlaceMines();

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (_minesweeper.mineGrid[i, j])
                        _minesweeper.SealACell(i, j);
                }
            Assert.IsFalse(_minesweeper.CheckGameWin());
        }

        [Test]
        public void testGameWinOnExposingAllNonMinedCells()
        {
            _minesweeper.PlaceMines();
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (!_minesweeper.mineGrid[i, j])
                        _minesweeper.ExposeCell(i, j);
                }
            Assert.IsFalse(_minesweeper.CheckGameWin());

        }

        [Test]
        public void testGameWinOnExposingAllNonMinedAndSealingAllMinedCells()
        {
            _minesweeper.PlaceMines();
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (!_minesweeper.mineGrid[i, j])
                        _minesweeper.ExposeCell(i, j);
                    if (_minesweeper.mineGrid[i, j])
                        _minesweeper.SealACell(i, j);
                }
            Assert.IsTrue(_minesweeper.CheckGameWin());

        }
    }
}
