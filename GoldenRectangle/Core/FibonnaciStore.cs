﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace GoldenRectangle.Core
{
    public class FibonnaciStore
    {
        #region Variables

        private static object _lock = new object();
        private static FibonnaciStore _instance;

        private List<int> _dataSource;

        #endregion

        #region Constructor
        private FibonnaciStore()
        {
            init();
        }

        #endregion

        #region Public members

        public static FibonnaciStore getInstance()
        {
            lock (_lock)
            {
                _instance = new FibonnaciStore();
            }

            return _instance;
        }

        #endregion

        #region Private members

        private void init()
        {
            int firstNumber = 1;
            int secondNumber = 1;

            _dataSource = new List<int>();
            _dataSource.Add(firstNumber);
            _dataSource.Add(secondNumber);

            while (firstNumber + secondNumber <= Constants.MAX_NUMBER_ALLOWED)
            {
                _dataSource.Add(firstNumber + secondNumber);

                secondNumber = firstNumber + secondNumber;
                firstNumber = secondNumber - firstNumber;
            }
        }

        // As Requested
        private int init_recursive(int firstNumber, int secondNumber)
        {
            if (_dataSource == null)
            {
                _dataSource = new List<int>();
                _dataSource.Add(firstNumber);
                _dataSource.Add(secondNumber);
            }

            if (firstNumber + secondNumber < Constants.MAX_NUMBER_ALLOWED)
            {
                _dataSource.Add(firstNumber + secondNumber);
                return init_recursive(secondNumber, firstNumber + secondNumber);
            }

            return firstNumber + secondNumber;
        }

        #endregion

        #region Public members

        public bool isValidFibonnaciNumber(int number)
        {
            if (_dataSource == null)
                throw new Exception("Fatal Error, Null Datasource");

            return _dataSource.Contains(number);
        }

        public List<int> getRespectiveFibonnaciSeries(int target)
        {
            List<int> returnValue = new List<int>();

            foreach (int entry in _dataSource)
            {
                if (entry > target)
                    break;

                returnValue.Add(entry);
            }

            return returnValue;
        }

        public int correctNumber(int target)
        {
            if (_dataSource == null)
                throw new Exception("Fatal Error, Null Datasource");

            return _dataSource.OrderBy(entry => Math.Abs(target - entry)).First();
        }

        #endregion
    }
}