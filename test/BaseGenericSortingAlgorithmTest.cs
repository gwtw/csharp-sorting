using Xunit;

namespace GrowingWithTheWeb.Sorting
{
    public abstract class BaseGenericSortingAlgorithmTest : BaseIntegerSortingAlgorithmTest {
        protected IGenericSortingAlgorithm<char> _charSortingAlgorithm;
        protected IGenericSortingAlgorithm<string> _stringSortingAlgorithm;

        public BaseGenericSortingAlgorithmTest(
                IGenericSortingAlgorithm<char> charSortingAlgorithm,
                IGenericSortingAlgorithm<string> stringSortingAlgorithm,
                IGenericSortingAlgorithm<int> integerSortingAlgorithm)
                : base(new GenericToIntegerSortingAlgorithmAdapter(integerSortingAlgorithm)) {
            _charSortingAlgorithm = charSortingAlgorithm;
            _stringSortingAlgorithm = stringSortingAlgorithm;
        }

        private class GenericToIntegerSortingAlgorithmAdapter : IIntegerSortingAlgorithm {
            private IGenericSortingAlgorithm<int> _algorithm;

            public GenericToIntegerSortingAlgorithmAdapter(IGenericSortingAlgorithm<int> algorithm) {
                _algorithm = algorithm; 
            }

            public void Sort(int[] array)
            {
                _algorithm.Sort(array);
            }
        }

        [Fact]
        public void SortSortedCharArrayTest() {
            var result = new char[] {'a','b','c','d','e'};
            _charSortingAlgorithm.Sort(result);
            Assert.Equal(new char[] {'a','b','c','d','e'}, result);
        }

        [Fact]
        public void SortReverseSortedCharArrayTest() {
            var result = new char[] {'e','d','c','b','a'};
            _charSortingAlgorithm.Sort(result);
            Assert.Equal(new char[] {'a','b','c','d','e'}, result);
        }

        [Fact]
        public void SortTwoValuesSwappedCharArrayTest() {
            var result = new char[] {'a','c','b','d','e'};
            _charSortingAlgorithm.Sort(result);
            Assert.Equal(new char[] {'a','b','c','d','e'}, result);
        }

        [Fact]
        public void SortJumbledCharArrayTest() {
            var result = new char[] {'i','b','a','h','c','g','d','f','e','j'};
            _charSortingAlgorithm.Sort(result);
            Assert.Equal(new char[] {'a','b','c','d','e','f','g','h','i','j'}, result);
        }

        [Fact]
        public void SortDuplicateValuesCharArrayTest() {
            var result = new char[] {'b','c','a','d','c','a','b','d'};
            _charSortingAlgorithm.Sort(result);
            Assert.Equal(new char[] {'a','a','b','b','c','c','d','d'}, result);
        }

        [Fact]
        public void SortSortingStringArrayTest() {
            var result = new string[] {"aa","bb","cc","dd","ee"};
            _stringSortingAlgorithm.Sort(result);
            Assert.Equal(new string[] {"aa","bb","cc","dd","ee"}, result);
        }

        [Fact]
        public void SortReverseSortedStringArrayTest() {
            var result = new string[] {"ee","dd","cc","bb","aa"};
            _stringSortingAlgorithm.Sort(result);
            Assert.Equal(new string[] {"aa","bb","cc","dd","ee"}, result);
        }

        [Fact]
        public void SortTwoValuesSwappedStringArrayTest() {
            var result = new string[] {"aa","cc","bb","dd","ee"};
            _stringSortingAlgorithm.Sort(result);
            Assert.Equal(new string[] {"aa","bb","cc","dd","ee"}, result);
        }

        [Fact]
        public void SortJumbledStringArrayTest() {
            var result = new string[] {"ii","bb","aa","hh","cc","gg","dd","ff","ee","jj"};
            _stringSortingAlgorithm.Sort(result);
            Assert.Equal(new string[] {"aa","bb","cc","dd","ee","ff","gg","hh","ii","jj"}, result);
        }

        [Fact]
        public void SortDuplicateValuesStringArrayTest() {
            var result = new string[] {"bb","cc","aa","dd","cc","aa","bb","dd"};
            _stringSortingAlgorithm.Sort(result);
            Assert.Equal(new string[] {"aa","aa","bb","bb","cc","cc","dd","dd"}, result);
        }

        [Fact]
        public void SortSecondCharacterInStringArrayTest() {
            var result = new string[] {"bb","ca","ab","da","cb","aa","ba","db"};
            _stringSortingAlgorithm.Sort(result);
            Assert.Equal(new string[] {"aa","ab","ba","bb","ca","cb","da","db"}, result);
        }
    }
}