using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizedSet
{
    public class RandomizedSet
    {
        private List<int> nums; //Store Elements for random access
        private Dictionary<int, int> map; //Map values to their indices in the list
        private Random random;

        public RandomizedSet()
        {
            nums = new List<int>();
            map = new Dictionary<int, int>();
            random = new Random();
        }

        public bool Insert(int val)
        {
            if (map.ContainsKey(val))
            {
                return false;
            }
            map[val] = nums.Count;
            nums.Add(val);
            return true;

        }

        public bool Remove(int val)
        {
            if (map.ContainsKey(val))
            {
                int index = map[val];
                int lastElement = nums[nums.Count - 1];

                nums[index] = lastElement;
                map[lastElement] = index;
                nums.RemoveAt(nums.Count - 1);
                map.Remove(val);
                return true;

            }
            return false;

        }

        public int GetRandom()
        {
            int randomIndex = random.Next(nums.Count);
            return nums[randomIndex];
        }
    }
}
