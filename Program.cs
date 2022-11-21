using System;

namespace Wild_West_Name_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            String nameInput = "";
            int randAdj = 0;
            int randAdjLy = 0;
            int randLine = 0;
            int randNickname = 0;
            string randLine1 = "a b";
            string randLine2 = "a b";
            string randLine3 = "a b";
            string randline4 = "a b";

            //These are the arrays I can pull from
            String[] adjective = { "adorable", "adventurous", "aggressive", "agreeable", "alert", "alive", "amused", "angry", "bad", "beautiful", "better", "bewildered", "black", "bloody", "blue", "blue-eyed", "annoyed", "annoying", "anxious", "arrogant", "ashamed", "attractive", "average", "awful", "blushing", "bored", "brainy", "brave", "breakable", "bright", "busy", "buttery", "calm", "careful", "cautious", "charming", "cheerful", "clean", "clear", "clever", "cloudy", "clumsy", "dangerous", "dark", "dead", "defeated", "defiant", "delightful", "depressed", "determined", "different", "colourful", "combative", "comfortable", "concerned", "condemned", "confused", "cooperative", "courageous", "curious", "cute", "difficult", "disgusted", "distinct", "disturbed", "dizzy", "doubtful", "drab", "dull", "dusty", "eager", "easy", "elated", "elegant", "embarrassed", "enchanting", "encouraging", "fair", "faithful", "famous", "fancy", "fantastic", "fierce", "filthy", "fine", "energetic", "enthusiastic", "envious", "evil", "excited", "expensive", "exuberant", "foolish", "fragile", "frail", "frantic", "friendly", "frightened", "funny", "furry", "gentle", "gifted", "glamorous", "gleaming", "glorious", "good", "handsome", "happy", "healthy", "helpful", "helpless", "hilarious", "gorgeous", "graceful", "grieving", "grotesque", "grumpy", "grungy", "homeless", "homely", "horrible", "hungry", "hurt", "hushed", "ill", "important", "impossible", "inexpensive", "innocent", "inquisitive", "lazy", "light", "lively", "lonely", "long", "lovely", "lucky", "itchy", "jealous", "jittery", "jolly", "joyous", "kind", "magnificent", "misty", "modern", "motionless", "muddy", "mushy", "mysterious", "nasty", "naughty", "nervous", "nice", "nutty", "obedient", "panicky", "perfect", "plain", "pleasant", "poised", "poor", "powerful", "obnoxious", "odd", "old-fashioned", "open", "outrageous", "outstanding", "precious", "prickly", "proud", "putrid", "puzzled", "quaint", "queasy", "real", "relieved", "repulsive", "rich", "scary", "selfish", "shiny", "shy", "silly", "sleepy", "smiling", "talented", "tame", "tasty", "tender", "tense", "terrible", "thankful", "thoughtful", "thoughtless", "tired", "smoggy", "sore", "sparkling", "splendid", "spotless", "stormy", "strange", "stupid", "successful", "super", "svelte", "tough", "troubled", "ugliest", "ugly", "uninterested", "unsightly", "unusual", "upset", "uptight", "useful", "vast", "victorious", "vivacious", "wandering", "weary", "wicked", "wide-eyed", "wild", "witty", "worried", "worrisome", "wrong", "zany", "zealous" };
            String[] adjectiveLy = { "abnormally", "absentmindedly", "accidentally", "actually", "adventurously", "almost", "always", "annually", "anxiously", "arrogantly", "awkwardly", "bashfully", "beautifully", "bitterly", "bleakly", "blindly", "blissfully", "boastfully", "boldly", "bravely", "briefly", "brightly", "briskly", "broadly", "busily", "calmly", "carefully", "carelessly", "cautiously", "certainly", "cheerfully", "clearly", "cleverly", "closely", "coaxingly", "colourfully", "commonly", "continually", "coolly", "correctly", "courageously", "crossly", "cruelly", "curiously", "daily", "daintily", "dearly", "deceivingly", "deeply", "defiantly", "deliberately", "delightfully", "diligently", "dimly", "doubtfully", "dreamily", "easily", "elegantly", "energetically", "enormously", "enthusiastically", "equally", "especially", "evenly", "eventually", "exactly", "excitedly", "extremely", "fairly", "faithfully", "famously", "fatally", "ferociously", "fervently", "fiercely", "fondly", "foolishly", "fortunately", "frankly", "frantically", "freely", "frenetically", "frightfully", "fully", "furiously", "generally", "generously", "gently", "gladly", "gleefully", "gracefully", "gratefully", "greatly", "greedily", "happily", "hastily", "healthily", "heavily", "helpfully", "helplessly", "highly", "honestly", "hopelessly", "hourly", "hungrily", "immediately", "innocently", "inquisitively", "instantly", "intensely", "intently", "interestingly", "inwardly", "irritably", "jaggedly", "jealously", "jovially", "joyfully", "joyously", "jubilantly", "judgmentally", "justly", "keenly", "kiddingly", "kind-heartedly", "kindly", "knavishly", "knowingly", "knowledgeably", "kookily", "lazily", "lightly", "likely", "limply", "lively", "loftily", "longingly", "loosely", "loudly", "lovingly", "loyally", "madly", "majestically", "meaningfully", "mechanically", "merrily", "miserably", "mockingly", "monthly", "mortally", "mostly", "mysteriously", "naturally", "more", "nearly", "neatly", "nervously", "nicely", "noisily", "obediently", "obnoxiously", "oddly", "offensively", "officially", "often", "only", "openly", "optimistically", "overconfidently", "painfully", "partially", "patiently", "perfectly", "physically", "playfully", "politely", "poorly", "positively", "potentially", "powerfully", "promptly", "properly", "punctually", "quaintly", "queasily", "queerly", "questionably", "quicker", "quickly", "quietly", "quirkily", "quizzically", "randomly", "rapidly", "rarely", "readily", "really", "reassuringly", "recklessly", "regularly", "reluctantly", "repeatedly", "reproachfully", "restfully", "righteously", "rightfully", "rigidly", "roughly", "rudely", "safely", "scarcely", "scarily", "searchingly", "sedately", "seemingly", "seldom", "selfishly", "separately", "seriously", "shakily", "sharply", "sheepishly", "shrilly", "shyly", "silently", "sleepily", "slowly", "smoothly", "softly", "solemnly", "solidly", "sometimes", "soon", "speedily", "stealthily", "sternly", "strictly", "successfully", "suddenly", "supposedly", "surprisingly", "suspiciously", "sweetly", "swiftly", "sympathetically", "tenderly", "tensely", "terribly", "thankfully", "thoroughly", "thoughtfully", "tightly", "tremendously", "triumphantly", "truly", "truthfully", "ultimately", "unabashedly", "unaccountably", "unbearably", "unethically", "unexpectedly", "unfortunately", "unimpressively", "unnaturally", "unnecessarily", "upbeat", "upright", "upside-down", "upward", "urgently", "usefully", "uselessly", "usually", "utterly", "vacantly", "vaguely", "vainly", "valiantly", "vastly", "verbally", "very", "viciously", "victoriously", "violently", "vivaciously", "voluntarily", "warmly", "weakly", "wearily", "well", "wetly", "wholly", "wildly", "wilfully", "wisely", "woefully", "wonderfully", "worriedly", "wrongly", "yawningly", "yearly", "yearningly", "yesterday", "yieldingly", "youthfully", "zealously", "zestfully", "zestily" };
            String[] nicknames = { "The Law", "Big Boss", "The Epitaph Author", "Truth", "Justice", "The Fiend", "Chiseller", "Bad Eye", "The Brains", "The Cheat", "Dust Devil", "Scalphunter", "Bloodlust", "Have Mercy", "Anklebiter", "The Devil", "Sunshine", "Muscles", "Scrongler", "Pain Train", "Slab", "Coffin Filler", "Wrathful Wrangler", "Hangman", "Spine Ripper", "Skull Squasher", "Rough n' tough", "Widowmaker", "Stand n’ Deliver", "Bone Breaker", "Steelfist", "Cobra Swinger", "Rattletail", "Carriage Cleaner", "Toothless", "Blood Boiler", "Gold Grafter", "The Chain", "Meat Maker", "The Demon", "Moonshiner", "Lasso", "Bullhorn", "King Cobra", "Steed Strider", "Horsefly", "God Fearin’", "Gravedigger", "Chin Chipper", "TNT", "Pickaxe", "Dust Devil", "Sandman", "Cow Rustler", "Nail Nibbler", "One-eyed", "Big Hat", "Hole-filler", "The Funeral", "Deputy Dragger", "High Noon", "Sundown", "Lark Lasher", "Pocket Pilferer", "Oh No", "Bullseye", "Sally Saddlin’", "Marksman", "Death Trap", "Unfortunate", "Big Biceped", "One-legged", "Tarantula-Eater", "Thousand Miles", "The Shadow", "The Brander", "Boneless", "Sidearm", "The Feisty", "The Hound", "Wildman", "Flattener", "Abnormality", "Tax Dodger", "Governor Pain", "Penny Sucker", "Spitoon", "Spitbowl", "Scorpion", "Moonlight", "Train Enthusiast", "The Good", "The Bad", "The Ugly", "The Exceedingly Ugly", "Calamity", "Roadrunner", "Naptime", "Preacher o' Pain", "Hot Head", "Jaw Dislocator", "Woe Wisher", "Strange Stranger", "Strangler", "Whack Job", "Nut Job", "Sunburnt", "Gold rush", "Dollar Bill", "The Millionaire", "Burnt Foot", "Earache", "Brain Basher", "Head Indenter", "Poison Brewer", "Venomous", "The Brass", "Spine Realligner", "Body Bagger", "Potato Licker" };

            //Intro text
            Console.ForegroundColor = ConsoleColor.White;
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(">Y'all cain't've come to these'ere parts without a yee-haw yankee nickname");

            //Request user name input
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine(">Tap out yer fullname and I'll give ya somethin' worthy o' the west!");
            Console.WriteLine("");

            while (true)
            {
                //Creates Random
                Random rnd = new Random();

                //Rolls Random values 
                randAdj = rnd.Next(0, adjective.Length-1);
                randAdjLy = rnd.Next(0, adjectiveLy.Length-1);
                randNickname = rnd.Next(0, nicknames.Length-1);
                randLine = rnd.Next(0, 4);
                
                //Deduplicate
                while (nicknames[randNickname] == "skip")
                {
                    randNickname = rnd.Next(0, nicknames.Length-1);
                }

                //Store user name input
                Console.ForegroundColor = ConsoleColor.Yellow;

                nameInput = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;

                //split user name input into an array
                String[] nameArray = nameInput.Split(' ');

                //Checks if "N/n/No/no" has been input to break the loop
                if (nameInput == "N" || nameInput == "n" || nameInput == "No" || nameInput == "no" || nameInput == "")
                {
                    //Break while loop
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("");
                    Console.WriteLine(">I'll be seein ya then pardner");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine(">Come by anytime for more o' me magnificent monikers");
                    System.Threading.Thread.Sleep(4000);
                    break;
                }

                //Generate varied randLine response options
                randLine1 = $">Eheh, I know.... {nameInput} \"The " + adjectiveLy[randAdjLy] + " " + adjective[randAdj] + "\" would be a fine name";
                if (nameArray.Length != 1)
                {
                    randLine2 = ">Ah-ha, what about.... " + nameArray[0] + " \"The " + adjectiveLy[randAdjLy] + " " + adjective[randAdj] + "\" " + nameArray[1];
                    randLine3 = ">Now then, I figure.... \"" + adjective[randAdj] + " " + nameArray[0] + "\" would suit ya rightly";
                    randline4 = ">How's about... " + nameArray[0] + " \"" + nicknames[randNickname] + "\" " + nameArray[1];
                }
                else
                {
                    //Set randLines all to be 1 if no surname available
                    randLine2 = randLine1;
                    randLine3 = randLine1;
                    randline4 = randLine1;
                }

                //build lines array to print from
                String[] lines = {randLine1, randLine2, randLine3, randline4};

                //Print and space randomly generated name
                Console.WriteLine("");
                Console.WriteLine(">...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(">Hmm...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(">........!");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine(lines[3]);

                Console.ForegroundColor = ConsoleColor.White;

                nicknames[randNickname] = "skip";

                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("");

                Console.WriteLine(">...are there more in yer posse to predicate? (N/Name)");
                Console.WriteLine("");
            }
        }
    }
}
