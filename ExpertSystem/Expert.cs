using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    public static class Expert
    {
        static Expert() 
        {
            InitRulesAndDictionary();
        }
        public enum TypeH { Holer = 0, Fleg, Melan, Sang }

        public static List<Rule> RulesList = new List<Rule>();
        static List<int> Holer = new List<int> { 3, 5, 7, 9, 10, 13, 16, 19, 23, 24, 26, 30, 31, 36 };
        static List<int> Fleg = new List<int> { 1, 2, 4, 14, 17, 25, 31, 34 };
        static List<int> Melan = new List<int> { 1, 2, 6, 8, 10, 12, 17, 20, 21, 22, 27, 29, 33, 34, 35, 37};
        static List<int> Sang = new List<int> { 0, 3, 5, 11, 14, 15, 18, 19, 24, 26, 28, 32};

        public static Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
        static void InitRulesAndDictionary()
        {
            RulesList.Add(new Rule { TextRule = "Часто ли Вы испытываете тягу к новым впечатлениям, к тому, чтобы встряхнуться, испытать возбуждение?", Is = false});
            RulesList.Add(new Rule { TextRule = "Часто ли Вы чувствуете, что нуждаетесь в друзьях, которые вас понимают, могут одобрить или утешить?", Is = false});
            RulesList.Add(new Rule { TextRule = "Считаете ли Вы себя безобидным человеком?", Is = false});
            RulesList.Add(new Rule { TextRule = "Очень ли трудно Вам отказаться от своих намерений?", Is = false});
            RulesList.Add(new Rule { TextRule = "Вы обдумываете свои дела не спеша, предпочитаете подождать, прежде чем действовать?", Is = false});
            RulesList.Add(new Rule { TextRule = "Вообще, Вы действуете и говорите быстро, не задерживаясь для обдумывания?", Is = false});
            RulesList.Add(new Rule { TextRule = "Возникало ли у Вас чувство, что Вы несчастный человек, хотя серьёзной причины для этого не было?", Is = false});
            RulesList.Add(new Rule { TextRule = "Верно ли, что Вы почти на всё могли бы решиться, если дело пошло на спор?", Is = false});
            RulesList.Add(new Rule { TextRule = "Вы смущаетесь, когда хотите завязать разговор с незнакомым человеком?", Is = false});
            RulesList.Add(new Rule { TextRule = "Бывает ли, что разозлившись, Вы выходите из себя?", Is = false});
            RulesList.Add(new Rule { TextRule = "Верно ли, что Вас довольно легко задеть?", Is = false});
            RulesList.Add(new Rule { TextRule = "Вы любите часто бывать в компании?", Is = false});
            RulesList.Add(new Rule { TextRule = "Бывают ли у Вас мысли, о которых неудобно рассказывать другим?", Is = false});
            RulesList.Add(new Rule { TextRule = "Когда на Вас кричат, отвечаете тем же?", Is = false});
            RulesList.Add(new Rule { TextRule = "Все ли ваши привычки хороши и желательны?", Is = false});
            RulesList.Add(new Rule { TextRule = "Способны ли Вы дать волю чувствам и вовсю повеселиться в шумной компании?", Is = false});
            RulesList.Add(new Rule { TextRule = "Можно ли сказать, что нервы бывают у Вас часто натянуты до предела?", Is = false});
            RulesList.Add(new Rule { TextRule = "После того как дело сделано, часто ли Вы мысленно возвращаетесь к нему, думая, что могли бы сделать лучше?.", Is = false});
            RulesList.Add(new Rule { TextRule = "Вы обычно чувствуете себя спокойным, когда находитесь в компании?", Is = false});
            RulesList.Add(new Rule { TextRule = "Бывает ли, что Вы передаёте слухи?", Is = false});
            RulesList.Add(new Rule { TextRule = "Если хотите узнать о чём-нибудь, то предпочитаете прочитать в книге, чем спросить у друзей?", Is = false});
            RulesList.Add(new Rule { TextRule = "Бывают ли у Вас приступы дрожи?", Is = false});
            RulesList.Add(new Rule { TextRule = "Вам неприятно бывать в компании, где подшучивают друг над другом?", Is = false});
            RulesList.Add(new Rule { TextRule = "Вы раздражительны?", Is = false});
            RulesList.Add(new Rule { TextRule = "Вам нравится работа, которая требует быстроты действия?", Is = false});
            RulesList.Add(new Rule { TextRule = "Вы медлительны и неторопливы в движениях?", Is = false});
            RulesList.Add(new Rule { TextRule = "Вы когда-нибудь опаздывали на свидания или на работу?", Is = false});
            RulesList.Add(new Rule { TextRule = "Часто ли вам снятся кошмары?", Is = false});
            RulesList.Add(new Rule { TextRule = "Вы любите поговорить настолько, что никогда не упустите удобный случай с незнакомым человеком?", Is = false});
            RulesList.Add(new Rule { TextRule = "Беспокоят ли вас какие-либо боли?", Is = false});
            RulesList.Add(new Rule { TextRule = "Можете ли Вы назвать себя нервным человеком?", Is = false});
            RulesList.Add(new Rule { TextRule = "Среди людей, которых Вы знаете, есть ли такие, которые Вам явно не нравятся?", Is = false});
            RulesList.Add(new Rule { TextRule = "Можете ли Вы сказать, что Вы уверенный в себе человек?", Is = false});
            RulesList.Add(new Rule { TextRule = "Обидитесь ли Вы, если покритиковать недостатки Ваши и Вашей работы?", Is = false});
            RulesList.Add(new Rule { TextRule = "Вы считаете, что трудно получить настоящее удовольствие от вечеринки?.", Is = false});
            RulesList.Add(new Rule { TextRule = "Вам трудно внести оживление в скучную компанию?", Is = false});
            RulesList.Add(new Rule { TextRule = "Вы любите подшучивать над другими?", Is = false});
            RulesList.Add(new Rule { TextRule = "Страдаете ли Вы от бессонницы?", Is = false});

            dictionary.Add((int)TypeH.Holer, Holer);
            dictionary.Add((int)TypeH.Fleg, Fleg);
            dictionary.Add((int)TypeH.Melan, Melan);
            dictionary.Add((int)TypeH.Sang, Sang);
        }
    }
}
