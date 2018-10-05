using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using YatzyCarl.Models;
using YatzyCarl.ViewModels;
using YatzyCarl.Views;

namespace YatzyCarl.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {
        }

        public void LoadHelp()
        {
            ActivateItem(new HelpViewModel());
        }
        public void LoadSettings()
        {
            ActivateItem(new SettingsViewModel());
        }
        public void LoadStatistics()
        {
            ActivateItem(new StatisticsViewModel());
        }
        public void LoadLogin()
        {
            ActivateItem(new LoginViewModel());
        }
        public void LoadGuest()
        {
            ActivateItem(new GuestLoginViewModel());
        }

        public void LoadNewUser()
        {
            ActivateItem(new NewUserViewModel());
        }
        public void LoadGame()
        {
            ActivateItem(new MainGameViewModel());
        }
      

        DicePanel panel = new DicePanel();
        ScoreCard card = new ScoreCard();

        int[] dices = new int[5] { 0, 0, 0, 0, 0 };
        public int[] diceValues = new int[6] { 0, 0, 0, 0, 0, 0 };
        bool[] keepDice = new bool[5] { false, false, false, false, false };

        private string _userName = "Bubbles_72";
        private int _ones = 0;
        private int _twos = 0;
        private int _threes = 0;
        private int _fours = 0;
        private int _fives = 0;
        private int _sixes = 0;
        private int _sum = 0;
        private int _bonus = 0;
        private int _pair = 0;
        private int _twoPairs = 0;
        private int _threeOfAKind = 0;
        private int _fourOfAKind = 0;
        private int _smallStraight = 0;
        private int _largeStraight = 0;
        private int _fullHouse = 0;
        private int _chance = 0;
        private int _yatzy = 0;
        private int _total = 0;
        private int _diceValue1 = 0;
        private int _diceValue2 = 0;
        private int _diceValue3 = 0;
        private int _diceValue4 = 0;
        private int _diceValue5 = 0;
        private bool _saveDiceOne = false;
        private bool _saveDiceTwo = false;
        private bool _saveDiceThree = false;
        private bool _saveDiceFour = false;
        private bool _saveDiceFive = false;

        public bool SaveDiceOne
        {
            get { return _saveDiceOne; }
            set
            {
                _saveDiceOne = value;
                if (value == true)
                    keepDice[0] = true;
                if (value == false)
                    keepDice[0] = false;
                NotifyOfPropertyChange(() => SaveDiceOne);
            }
        } // spara värdet om saveDice är kryssad
        public bool SaveDiceTwo
        {
            get { return _saveDiceTwo; }
            set
            {
                _saveDiceTwo = value; ;
                if (true)
                    keepDice[1] = true;
                if (value == false)
                    keepDice[1] = false;
                NotifyOfPropertyChange(() => SaveDiceTwo);
            }
        }
        public bool SaveDiceThree
        {
            get { return _saveDiceThree; }
            set
            {
                _saveDiceThree = value;
                if (true)
                    keepDice[2] = true;
                if (value == false)
                    keepDice[2] = false;
                NotifyOfPropertyChange(() => SaveDiceThree);
            }
        }
        public bool SaveDiceFour
        {
            get { return _saveDiceFour; }
            set
            {
                _saveDiceFour = value;
                if (true)
                    keepDice[3] = true;
                if (value == false)
                    keepDice[3] = false;
                NotifyOfPropertyChange(() => SaveDiceFour);
            }
        }
        public bool SaveDiceFive
        {
            get { return _saveDiceFive; }
            set
            {
                _saveDiceFive = value; ;
                if (true)
                    keepDice[4] = true;
                if (value == false)
                    keepDice[4] = false;
                NotifyOfPropertyChange(() => SaveDiceFive);
            }
        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
            }
        }
        public int Ones
        {
            get { return _ones; }
            set
            {
                _ones = value;
                NotifyOfPropertyChange(() => Ones);
            }
        }
        public int Twos
        {
            get { return _twos; }
            set
            {
                _twos = value;
                NotifyOfPropertyChange(() => Twos);
            }
        }
        public int Threes
        {
            get { return _threes; }
            set
            {
                _threes = value;
                NotifyOfPropertyChange(() => Threes);
            }
        }
        public int Fours
        {
            get { return _fours; }
            set
            {
                _fours = value;
                NotifyOfPropertyChange(() => Fours);
            }
        }
        public int Fives
        {
            get { return _fives; }
            set
            {
                _fives = value;
                NotifyOfPropertyChange(() => Fives);
            }
        }
        public int Sixes
        {
            get { return _sixes; }
            set
            {
                _sixes = value;
                NotifyOfPropertyChange(() => Sixes);
            }
        }
        public int Sum
        {
            get { return _sum; }
            set
            {
                _sum = value;
                NotifyOfPropertyChange(() => Sum);
            }
        }
        public int Bonus
        {
            get { return _bonus; }
            set
            {
                _bonus = value;
                NotifyOfPropertyChange(() => Bonus);
            }
        }
        public int Pairs
        {
            get { return _pair; }
            set
            {
                _pair = value;
                NotifyOfPropertyChange(() => Pairs);
            }
        }
        public int TwoPairss
        {
            get { return _twoPairs; }
            set
            {
                _twoPairs = value;
                NotifyOfPropertyChange(() => TwoPairss);
            }
        }
        public int ThreeOfAKinds
        {
            get { return _threeOfAKind; }
            set
            {
                _threeOfAKind = value;
                NotifyOfPropertyChange(() => ThreeOfAKinds);
            }
        }
        public int FourOfAKinds
        {
            get { return _fourOfAKind; }
            set
            {
                _fourOfAKind = value;
                NotifyOfPropertyChange(() => FourOfAKinds);
            }
        }
        public int SmallStraights
        {
            get { return _smallStraight; }
            set
            {
                _smallStraight = value;
                NotifyOfPropertyChange(() => SmallStraights);
            }
        }
        public int LargeStraights
        {
            get { return _largeStraight; }
            set
            {
                _largeStraight = value;
                NotifyOfPropertyChange(() => LargeStraights);
            }
        }
        public int FullHouses
        {
            get { return _fullHouse; }
            set
            {
                _fullHouse = value;
                NotifyOfPropertyChange(() => FullHouses);
            }
        }
        public int Chances
        {
            get { return _chance; }
            set
            {
                _chance = value;
                NotifyOfPropertyChange(() => Chances);
            }
        }
        public int Yatzys
        {
            get { return _yatzy; }
            set
            {
                _yatzy = value;
                NotifyOfPropertyChange(() => Yatzys);
            }
        }
        public int Total
        {
            get { return _total; }
            set
            {
                _total = value;
                NotifyOfPropertyChange(() => Total);
            }
        }
        public int DiceValue1
        {
            get { return _diceValue1; }
            set
            {
                _diceValue1 = value;
                NotifyOfPropertyChange(() => DiceValue1);
            }
        }
        public int DiceValue2
        {
            get { return _diceValue2; }
            set
            {
                _diceValue2 = value;
                NotifyOfPropertyChange(() => DiceValue2);
            }
        }
        public int DiceValue3
        {
            get { return _diceValue3; }
            set
            {
                _diceValue3 = value;
                NotifyOfPropertyChange(() => DiceValue3);
            }
        }
        public int DiceValue4
        {
            get { return _diceValue4; }
            set
            {
                _diceValue4 = value;
                NotifyOfPropertyChange(() => DiceValue4);
            }
        }
        public int DiceValue5
        {
            get { return _diceValue5; }
            set
            {
                _diceValue5 = value;
                NotifyOfPropertyChange(() => DiceValue5);
            }
        }

        public void RollDice()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i] = panel.FirstRoll();

                if (keepDice[0] == false)
                {
                    dices[0] = panel.FirstRoll();
                    DiceValue1 = dices[0];
                }
                else dices[0] = DiceValue1;

                if (keepDice[1] == false)
                {
                    dices[1] = panel.FirstRoll();
                    DiceValue2 = dices[1];
                }
                else dices[1] = DiceValue2;

                if (keepDice[2] == false)
                {
                    dices[2] = panel.FirstRoll();
                    DiceValue3 = dices[2];
                }
                else dices[2] = DiceValue3;

                if (keepDice[3] == false)
                {
                    dices[3] = panel.FirstRoll();
                    DiceValue4 = dices[3];

                }
                else dices[3] = DiceValue4;

                if (keepDice[4] == false)
                {
                    dices[4] = panel.FirstRoll();
                    DiceValue5 = dices[4];
                }
                else dices[4] = DiceValue5;
            }
        }  // slumpa tärningsslag och samtidigt kolla om man ska spara tärningar
        public void SaveToDiceValue()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                switch (dices[i])
                {
                    case 1:
                        diceValues[0]++;
                        break;
                    case 2:
                        diceValues[1]++;
                        break;
                    case 3:
                        diceValues[2]++;
                        break;
                    case 4:
                        diceValues[3]++;
                        break;
                    case 5:
                        diceValues[4]++;
                        break;
                    case 6:
                        diceValues[5]++;
                        break;
                }
                clearSaveDices();
                ClearDiceValues();
            }

        } // Alla kategoriefunktioner läser av diceValue arrayen så här sparas det ner till denna.
        public void ClearDice()
        {
            for (int i = 0; i < keepDice.Length; i++)
            {
                keepDice[i] = false;
            }
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i] = 0;
            }

        } // rensa dices och keepdices
        public void clearSaveDices()
        {
            SaveDiceOne = false;
            SaveDiceTwo = false;
            SaveDiceThree = false;
            SaveDiceFour = false;
            SaveDiceFive = false;
        } // nollställ checkrutor
        public void ClearDiceValues()
        {
            DiceValue1 = 0;
            DiceValue2 = 0;
            DiceValue3 = 0;
            DiceValue4 = 0;
            DiceValue5 = 0;
        } // nollställ tärningsgränssnittet

        public int One(int[] diceValue)

        {

            int result = 0;

            result += diceValue[0];

            return result;

        }
        public int Two(int[] diceValues)

        {

            int result = 0;

            result += diceValues[1] * 2;

            return result;

        }
        public int Three(int[] diceValues)

        {

            int result = 0;

            result += diceValues[2] * 3;

            return result;

        }
        public int Four(int[] diceValues)

        {

            int result = 0;

            result += diceValues[3] * 4;

            return result;

        }
        public int Five(int[] diceValues)

        {

            int result = 0;

            result += diceValues[4] * 5;

            return result;

        }
        public int Six(int[] diceValues)

        {

            int result = 0;

            result += diceValues[5] * 6;

            return result;

        }
        public int Pair(int[] diceValues)

        {

            int result = 0;



            for (int i = 0; i < diceValues.Length; i++)

            {

                if (diceValues[5] >= 2)

                {

                    result = 12;

                }

                else if (diceValues[4] >= 2)

                {

                    result = 10;

                }

                else if (diceValues[3] >= 2)

                {

                    result = 8;

                }

                else if (diceValues[2] >= 2)

                {

                    result = 6;

                }

                else if (diceValues[1] >= 2)

                {

                    result = 4;

                }

                else if (diceValues[0] >= 2)

                {

                    result = 2;

                }

                else result = 0;

            }

            return result;

        }
        public int TwoPair(int[] diceValues)
        {
            int result = 0;

            for (int i = 0; i < diceValues.Length; i++)
            {
                if (diceValues[0] >= 2 && diceValues[1] == 2)
                    result = 6;
                if (diceValues[0] >= 2 && diceValues[2] == 2)
                    result = 8;
                if (diceValues[0] >= 2 && diceValues[3] == 2)
                    result = 10;
                if (diceValues[0] >= 2 && diceValues[4] == 2)
                    result = 12;
                if (diceValues[0] >= 2 && diceValues[5] == 2)
                    result = 14;
                if (diceValues[1] >= 2 && diceValues[0] == 2)
                    result = 6;
                if (diceValues[1] >= 2 && diceValues[2] == 2)
                    result = 10;
                if (diceValues[1] >= 2 && diceValues[3] == 2)
                    result = 12;
                if (diceValues[1] >= 2 && diceValues[4] == 2)
                    result = 14;
                if (diceValues[1] >= 2 && diceValues[5] == 2)
                    result = 16;
                if (diceValues[2] >= 2 && diceValues[0] == 2)
                    result = 8;
                if (diceValues[2] >= 2 && diceValues[1] == 2)
                    result = 10;
                if (diceValues[2] >= 2 && diceValues[3] == 2)
                    result = 14;
                if (diceValues[2] >= 2 && diceValues[4] == 2)
                    result = 16;
                if (diceValues[2] >= 2 && diceValues[5] == 2)
                    result = 18;
                if (diceValues[3] >= 2 && diceValues[0] == 2)
                    result = 10;
                if (diceValues[3] >= 2 && diceValues[1] == 2)
                    result = 12;
                if (diceValues[3] >= 2 && diceValues[2] == 2)
                    result = 14;
                if (diceValues[3] >= 2 && diceValues[4] == 2)
                    result = 18;
                if (diceValues[3] >= 2 && diceValues[5] == 2)
                    result = 20;
                if (diceValues[4] >= 2 && diceValues[0] == 2)
                    result = 12;
                if (diceValues[4] >= 2 && diceValues[1] == 2)
                    result = 14;
                if (diceValues[4] >= 2 && diceValues[2] == 2)
                    result = 16;
                if (diceValues[4] >= 2 && diceValues[3] == 2)
                    result = 18;
                if (diceValues[4] >= 2 && diceValues[5] == 2)
                    result = 22;
                if (diceValues[5] >= 2 && diceValues[0] == 2)
                    result = 14;
                if (diceValues[5] >= 2 && diceValues[1] == 2)
                    result = 16;
                if (diceValues[5] >= 2 && diceValues[2] == 2)
                    result = 18;
                if (diceValues[5] >= 2 && diceValues[3] == 2)
                    result = 20;
                if (diceValues[5] >= 2 && diceValues[4] == 2)
                    result = 22;
            }
            return result;
        } // ingen vacker lösning men fungerar!
        //public int TwoPair(int[] diceValues)
        //{
        //    int result = 0;

        //    for (int i = 0; i < diceValues.Length; i++)
        //    {
        //        if (diceValues[i] == 2)
        //            for (int j = 0; j < diceValues.Length; j++)
        //            {
        //                if (diceValues[i] == 2)
        //                {
        //                    result = 20;
        //                }
        //            }
        //    }
        //    return result;
        //}
        public int ThreeOfKind(int[] diceValues)

        {

            int result = 0;



            for (int i = 0; i < diceValues.Length; i++)

            {

                if (diceValues[0] >= 3)

                    result = 3;

                else if (diceValues[1] >= 3)

                    result = 6;

                else if (diceValues[2] >= 3)

                    result = 9;

                else if (diceValues[3] >= 3)

                    result = 12;

                else if (diceValues[4] >= 3)

                    result = 15;

                else if (diceValues[5] >= 3)

                    result = 18;

                else result = 0;

            }

            return result;

        }
        public int FourOfKind(int[] diceValues)

        {

            int result = 0;



            for (int i = 0; i < diceValues.Length; i++)

            {

                if (diceValues[0] >= 4)

                    result = 4;

                else if (diceValues[1] >= 4)

                    result = 8;

                else if (diceValues[2] >= 4)

                    result = 12;

                else if (diceValues[3] >= 4)

                    result = 16;

                else if (diceValues[4] >= 4)

                    result = 20;

                else if (diceValues[5] >= 4)

                    result = 24;

                else result = 0;

            }

            return result;

        }
        public int BigStraight(int[] diceValues)

        {

            int result = 0;



            for (int i = 0; i < diceValues.Length; i++)

            {

                if (diceValues[1] == 1 && diceValues[2] == 1 && diceValues[3] == 1 && diceValues[4] == 1 && diceValues[5] == 1)

                {

                    result = 20;

                }

                else result = 0;

            }





            return result;



        }
        public int SmallStraight(int[] diceValues)

        {

            int result = 0;



            for (int i = 0; i < diceValues.Length; i++)

            {

                if (diceValues[0] == 1 && diceValues[1] == 1 && diceValues[2] == 1 && diceValues[3] == 1 && diceValues[4] == 1)

                {

                    result = 15;

                }

            }

            return result;



        }
        public int Chance(int[] diceValues)

        {

            int result = 0;



            for (int i = 0; i < diceValues.Length; i++)

            {

                result = (diceValues[0] + diceValues[1] * 2 + diceValues[2] * 3 + diceValues[3] * 4 + diceValues[4] * 5 + diceValues[5] * 6);

            }

            return result;

        }
        public int FullHouse(int[] diceValues)
        {
            int result = 0;

            for (int i = 0; i < diceValues.Length; i++)
            {
                if (diceValues[0] == 3 && diceValues[1] == 2)
                    result = 7;
                if (diceValues[0] == 3 && diceValues[2] == 2)
                    result = 9;
                if (diceValues[0] == 3 && diceValues[3] == 2)
                    result = 11;
                if (diceValues[0] == 3 && diceValues[4] == 2)
                    result = 13;
                if (diceValues[0] == 3 && diceValues[5] == 2)
                    result = 15;
                if (diceValues[1] == 3 && diceValues[0] == 2)
                    result = 8;
                if (diceValues[1] == 3 && diceValues[2] == 2)
                    result = 12;
                if (diceValues[1] == 3 && diceValues[3] == 2)
                    result = 14;
                if (diceValues[1] == 3 && diceValues[4] == 2)
                    result = 16;
                if (diceValues[1] == 3 && diceValues[5] == 2)
                    result = 18;
                if (diceValues[2] == 3 && diceValues[0] == 2)
                    result = 11;
                if (diceValues[2] == 3 && diceValues[1] == 2)
                    result = 13;
                if (diceValues[2] == 3 && diceValues[3] == 2)
                    result = 17;
                if (diceValues[2] == 3 && diceValues[4] == 2)
                    result = 19;
                if (diceValues[2] == 3 && diceValues[5] == 2)
                    result = 21;
                if (diceValues[3] == 3 && diceValues[0] == 2)
                    result = 14;
                if (diceValues[3] == 3 && diceValues[1] == 2)
                    result = 16;
                if (diceValues[3] == 3 && diceValues[2] == 2)
                    result = 18;
                if (diceValues[3] == 3 && diceValues[4] == 2)
                    result = 22;
                if (diceValues[3] == 3 && diceValues[5] == 2)
                    result = 24;
                if (diceValues[4] == 3 && diceValues[0] == 2)
                    result = 17;
                if (diceValues[4] == 3 && diceValues[1] == 2)
                    result = 19;
                if (diceValues[4] == 3 && diceValues[2] == 2)
                    result = 21;
                if (diceValues[4] == 3 && diceValues[3] == 2)
                    result = 23;
                if (diceValues[4] == 3 && diceValues[5] == 2)
                    result = 27;
                if (diceValues[5] == 3 && diceValues[0] == 2)
                    result = 20;
                if (diceValues[5] == 3 && diceValues[1] == 2)
                    result = 22;
                if (diceValues[5] == 3 && diceValues[2] == 2)
                    result = 24;
                if (diceValues[5] == 3 && diceValues[3] == 2)
                    result = 26;
                if (diceValues[5] == 3 && diceValues[4] == 2)
                    result = 28;
            }
            return result;
        } // ingen vacker lösning men fungerar!
        public int Yatzee(int[] diceValues)
        {
            int result = 0;
            for (int i = 0; i < diceValues.Length; i++)
            {
                if (diceValues[0] == 5)
                    result = 50;
                else if (diceValues[1] == 5)
                    result = 50;
                else if (diceValues[2] == 5)
                    result = 50;
                else if (diceValues[3] == 5)
                    result = 50;
                else if (diceValues[4] == 5)
                    result = 50;
                else if (diceValues[5] == 5)
                    result = 50;

                else result = 0;
            }

            return result;
        }
        //public int[] FullHouse()
        //{

        //}

        //public int FullHouse(int[] diceValues)

        //{
        //    int result = 0;
        //    for (int i = 0; i < diceValues.Length; i++)
        //    {
        //        if (diceValues[i] == 3)

        //            for (int j = 0; j < diceValues.Length; j++)

        //            {

        //                if (diceValues[i] == 2)

        //                    result = 25;
        //            }
        //    }
        //    return result;

        //}

        public int[] GetAllResults()
        {
            int[] diceResults = new int[15];

            if (One(diceValues) > 0)
            {
                diceResults[0] = One(diceValues);
            }
            if (Two(diceValues) > 0)
            {
                diceResults[1] = Two(diceValues);
            }
            if (Three(diceValues) > 0)
            {
                diceResults[2] = Three(diceValues);
            }
            if (Four(diceValues) > 0)
            {
                diceResults[3] = Four(diceValues);
            }
            if (Five(diceValues) > 0)
            {
                diceResults[4] = Five(diceValues);
            }
            if (Six(diceValues) > 0)
            {
                diceResults[5] = Six(diceValues);
            }
            if (Pair(diceValues) > 0)
            {
                diceResults[6] = Pair(diceValues);
            }
            if (TwoPair(diceValues) > 0)
            {
                diceResults[7] = TwoPair(diceValues);
            }
            if (ThreeOfKind(diceValues) > 0)
            {
                diceResults[8] = ThreeOfKind(diceValues);
            }
            if (FourOfKind(diceValues) > 0)
            {
                diceResults[9] = FourOfKind(diceValues);
            }
            if (SmallStraight(diceValues) > 0)
            {
                diceResults[10] = SmallStraight(diceValues);
            }
            if (BigStraight(diceValues) > 0)
            {
                diceResults[11] = BigStraight(diceValues);
            }
            if (FullHouse(diceValues) > 0)
            {
                diceResults[12] = FullHouse(diceValues);
            }
            if (Chance(diceValues) > 0)
            {
                diceResults[13] = Chance(diceValues);
            }
            if (Yatzee(diceValues) > 0)
            {
                diceResults[14] = Yatzee(diceValues);
            }
            return diceResults;
        }  // få ut alla 15 kategorieresultat i en lista (som man sedan kan presentera i gränssnittet)
        public void Resultat()
        {
            //int[] PoängLista = GetAllResults();
            //int result = Yatzee(diceValues);
            CalculateSum();
        }   // testknapp

        public void PickOne()
        {
            SaveToDiceValue();
            Ones = One(diceValues);
            CalculateSum();
            CalculateBonus();
            CalculateTotal();
        }  // presntera i gränssnitett
        public void PickTwo()
        {
            SaveToDiceValue();
            Twos = Two(diceValues);
            CalculateSum();
            CalculateBonus();
            CalculateTotal();
        }
        public void PickThree()
        {
            SaveToDiceValue();
            Threes = Three(diceValues);
            CalculateSum();
            CalculateBonus();
            CalculateTotal();
        }
        public void PickFour()
        {
            SaveToDiceValue();
            Fours = Four(diceValues);
            CalculateSum();
            CalculateBonus();
            CalculateTotal();
        }
        public void PickFive()
        {
            SaveToDiceValue();
            Fives = Five(diceValues);
            CalculateSum();
            CalculateBonus();
            CalculateTotal();
        }
        public void PickSix()
        {
            SaveToDiceValue();
            Sixes = Six(diceValues);
            CalculateSum();
            CalculateBonus();
            CalculateTotal();
        }
        public void PickPair()
        {
            SaveToDiceValue();
            Pairs = Pair(diceValues);
            CalculateSum();
            CalculateBonus();
            CalculateTotal();
        }
        public void PickTwoPair()
        {
            SaveToDiceValue();
            TwoPairss = TwoPair(diceValues);
            CalculateSum();
            CalculateBonus();
            CalculateTotal();
        }
        public void PickThreeOfKind()
        {
            SaveToDiceValue();
            ThreeOfAKinds = ThreeOfKind(diceValues);
            CalculateSum();
            CalculateBonus();
            CalculateTotal();
        }
        public void PickFourOfKInd()
        {
            SaveToDiceValue();
            FourOfAKinds = FourOfKind(diceValues);
            CalculateSum();
            CalculateBonus();
            CalculateTotal();
        }
        public void PickSmallStraight()
        {
            SaveToDiceValue();
            SmallStraights = SmallStraight(diceValues);
            CalculateSum();
            CalculateBonus();
            CalculateTotal();
        }
        public void PickLargeStraight()
        {
            SaveToDiceValue();
            LargeStraights = BigStraight(diceValues);
            CalculateSum();
            CalculateBonus();
            CalculateTotal();
        }
        public void PickFullHouse()
        {
            SaveToDiceValue();
            FullHouses = FullHouse(diceValues);
            CalculateSum();
            CalculateBonus();
            CalculateTotal();
        }
        public void PickChance()
        {
            SaveToDiceValue();
            Chances = Chance(diceValues);
            CalculateSum();
            CalculateBonus();
            CalculateTotal();
        }
        public void PickYatzy()
        {
            SaveToDiceValue();
            Yatzys = Yatzee(diceValues);
            CalculateSum();
            CalculateBonus();
            CalculateTotal();
        }

        public void ShowAllPickedValues()
        {
            PickOne();
            PickTwo();
            PickThree();
            PickFour();
            PickFive();
            PickSix();
            PickPair();
            PickTwoPair();
            PickThreeOfKind();
            PickFourOfKInd();
            PickSmallStraight();
            PickLargeStraight();
            PickFullHouse();
            PickChance();
            PickYatzy();


        } // visar alla möjliga resultat i gränssnitt

        public void CalculateSum()
        {
            Sum = Ones + Twos + Threes + Fours + Fives + Sixes;
        }
        public void CalculateBonus()
        {
            if (Sum >= 63)
                Bonus = 50;
            else Bonus = 0;
        }
        public void CalculateTotal()
        {
            Total = Sum + Bonus + Pairs + TwoPairss + ThreeOfAKinds + FourOfAKinds + SmallStraights + LargeStraights + FullHouses + Chances + Yatzys;
        }

    }
}

