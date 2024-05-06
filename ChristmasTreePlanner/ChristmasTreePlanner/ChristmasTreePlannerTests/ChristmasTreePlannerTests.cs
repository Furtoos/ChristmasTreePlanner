namespace ChristmasTreePlannerTests
{
    using ChristmasTreePlanner;
    using FluentAssertions;

    public class ChristmasTreePlannerTests
    {
        [Fact]
        public void PlanChristmasTrees_Size2_ShouldReturnEmptyInput()
        {
            ChristmasTree planner = new ChristmasTree();
            char[,] result = planner.PlanChristmasTrees(2);
            Assert.Equal(new char[0, 0], result);
        }

        [Fact]
        public void PlanChristmasTrees_Size4_ValidTreeReturned()
        {
            ChristmasTree planner = new ChristmasTree();
            char[,] expected = {
                { '-', 'O', '-', '-' },
                { '-', '-', '-', 'O' },
                { 'O', '-', '-', '-' },
                { '-', '-', 'O', '-' }
            };
            char[,] result = planner.PlanChristmasTrees(4);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PlanChristmasTrees_Size5_ValidTreeReturned()
        {
            ChristmasTree planner = new ChristmasTree();
            char[,] expected = {
                { 'O', '-', '-', '-', '-' },
                { '-', '-', 'O', '-', '-' },
                { '-', '-', '-', '-', 'O' },
                { '-', 'O', '-', '-', '-' },
                { '-', '-', '-', 'O', '-' }
            };
            char[,] result = planner.PlanChristmasTrees(5);
            Assert.Equal(expected, result);
        }
    }
}