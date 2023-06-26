using SelocanusToolkit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Selocanus
{
    //Checks active Tic Tac Toe Games state
    public class TicTacToeManager : MonoBehaviour
    {
        //Each slot has a state of either -1, 0 or 1
        // -1 => X / 0 => Null / 1 => O
        [Header("Vanilla Game Variables")]
        [SerializeField] int[] m_SlotStates = new int[9];
        [Header("Advanced Game Variables")]
        [SerializeField] int m_SlotsPerRow = 3;
        [SerializeField] int m_SlotsPerColumn = 3;
        private int m_DiagonalChecks;

        private void Start()
        {
            m_DiagonalChecks = (m_SlotsPerRow - 2) * (m_SlotsPerColumn - 2) * 2;
        }

        //Checks if game ends
        public void CheckGameStatus()
        {
            int target;
            //Define board checking Rules
            //Check Slots Vertically 
            for (int i = 0; i < m_SlotsPerRow; i++)
            {
                target = i;
            }
            //Check Slots Horizontally 
            for (int i = 0; i < m_SlotsPerColumn; i++)
            {
                target = i + (i * (m_SlotsPerColumn - 1));
            }
            //Check Slots Diagonally
            for (int i = 0; i < m_DiagonalChecks; i++)
            {
                target = (i * (m_SlotsPerRow - 2));
            }
        }

        private bool CheckVertically()
        {
            return false;
        }

        private bool CheckHorizontally()
        {
            return false;
        }
        private bool CheckDiagonally()
        {
            return false;
        }
    }
}

