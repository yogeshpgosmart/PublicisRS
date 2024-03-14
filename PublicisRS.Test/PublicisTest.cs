namespace PublicisRS.Test
{
    public class PublicisTest
    {
        [Fact]
        public void PrintPublicisName()
        {
            //Arrange 
            PrintNameOrNumber printPUBLICSName = new PrintNameOrNumber();
            int number = 3;
            //Action 
            string result = printPUBLICSName.Publicis(number);
            //Asserts
            Assert.Equal("Publicis", result);
        }

        [Fact]
        public void PrintROarName()
        {
            //Arrange 
            PrintNameOrNumber printPUBLICSName = new PrintNameOrNumber();
            int number = 5;
            //Action 
            string result = printPUBLICSName.ROar(number);
            //Asserts
            Assert.Equal("rOar", result);
        }

        [Fact]
        public void PrintPublicisROar()
        {
            //Arrange 
            PrintNameOrNumber printPUBLICSName = new PrintNameOrNumber();
            int number = 15;
            //Action 
            string result = printPUBLICSName.PublicisrOar(number);
            //Asserts
            Assert.Equal("PublicisrOar", result);
        }

        [Fact]
        public void PrintNumber()
        {
            PrintNameOrNumber printPUBLICSName = new PrintNameOrNumber();
            int number = 1;
            //Action 
            string result = printPUBLICSName.PrintNumber(number);
            //Asserts
            Assert.Equal("1", result);
        }

    }
}