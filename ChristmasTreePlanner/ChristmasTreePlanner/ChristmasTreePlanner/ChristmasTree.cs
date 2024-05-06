namespace ChristmasTreePlanner
{
    public class ChristmasTree
    {
        public char[,] PlanChristmasTrees(int n)
        {
            char[,] area = new char[n, n];
            bool success = PlaceTrees(area, 0, n);
            FillZeroValues(area, n);
            return success ? area : new char[0, 0];
        }

        private bool PlaceTrees(char[,] area, int row, int n)
        {
            if (row == n)
                return true;

            for (int col = 0; col < n; col++)
            {
                if (IsSafe(area, row, col, n))
                {
                    area[row, col] = 'O';

                    if (PlaceTrees(area, row + 1, n))
                        return true;

                    area[row, col] = '-';
                }
            }

            return false;
        }

        private bool IsSafe(char[,] area, int row, int col, int n)
        {
            for (int i = 0; i < row; i++)
            {
                if (area[i, col] == 'O')
                    return false;
            }

            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (area[i, j] == 'O')
                    return false;
            }

            for (int i = row, j = col; i >= 0 && j < n; i--, j++)
            {
                if (area[i, j] == 'O')
                    return false;
            }

            return true;
        }

        private void FillZeroValues(char[,] allotment, int n)
        {
            for(int row = 0; row < n; row++) {
                for(int col = 0; col < n; col++)
                {
                    if(allotment[row, col] != 'O')
                    {
                        allotment[row, col] = '-';
                    }
                }
            }
        }
    }
}
