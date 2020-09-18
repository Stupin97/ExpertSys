using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    public class Analiz
    {
        public int Total { get; set; }

        public Analiz() { }

        public string GetResult()
        {
            int temp = 0, max = 0, index = 0, tempIndex = 0;

            foreach (var p in Expert.dictionary.Values)
            {
                for (int i = 0; i < p.Count; i++)
                {
                    if(Expert.RulesList[p[i]].Is == true)
                    {
                        temp++;
                    }
                }

                if(temp > max)
                {
                    max = temp;
                    index = tempIndex;
                }

                tempIndex++;
            }

            return GetAnswer(index);
        }

        string GetAnswer(int i)
        {
            string answer = "";
            switch (i)
            {
                case 0: 
                    answer = "Холерик";
                    break;
                case 1:
                    answer = "Флегматик";
                    break;
                case 2:
                    answer = "Меланхолик";
                    break;
                case 3:
                    answer = "Сангвиник";
                    break;
            }
            return answer;
        }
    }
}
