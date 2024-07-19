List<int> lucks = new List<int>();        
        for (int row=0; row<matrix.Length; row++)
        {
            int rowMin = int.MaxValue;
            int currentCol = 0;
            for (int col=0; col<matrix[row].Length; col++)
            {
                if (matrix[row][col] < rowMin)
                {
                    rowMin = matrix[row][col];
                    currentCol = col;
                }
            }

            int colMax = int.MinValue;
            for (int row1=0; row1<matrix.Length; row1++)
            {
                if (matrix[row1][currentCol] > colMax)
                {
                    colMax = matrix[row1][currentCol];                   
                }
            }    

            if (rowMin == colMax)
            {
                lucks.Add(rowMin);                   
            }
        }
     
        return lucks;
