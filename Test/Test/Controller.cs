namespace Test
{
    class Controller
    {
        IView myView;
        Model myModel;
        ExceriseTwoModel exTwoModel;
        ExThreeModel exThreeModel;
        ExFourModel exFourModel;
        ExFiveModel exFiveModel;
        ExSixModel exSixModel;
        ExSevenModel exSevenModel;
        ExEightModel exEightModel;
        ExNineModel exNinemodel;
        ExTenModel exTenModel;
        ExElevnModel exElevenModel;

        public Controller(IView newView,Model newModel, ExceriseTwoModel newExTwoModel,ExThreeModel newExThreeModel,
            ExFourModel newExFourModel, ExFiveModel newExFiveModel, ExSixModel newExSixModel, ExSevenModel newExSevenModel,
            ExEightModel newExEightModel,ExNineModel newExNineModel, ExTenModel newexTenModel, ExElevnModel newElvenModel )
        {
            myView = newView;
            myModel = newModel;
            exTwoModel = newExTwoModel;
            exThreeModel = newExThreeModel;
            exFourModel = newExFourModel;
            exFiveModel = newExFiveModel;
            exSixModel = newExSixModel;
            exSevenModel = newExSevenModel;
            exEightModel = newExEightModel;
            exNinemodel = newExNineModel;
            exTenModel = newexTenModel;
            exElevenModel = newElvenModel;
        }

        public void Go()
        {
            myView.Say("Please enter the number to reveal the answers for the question");
            int questionNumber = int.Parse(myView.Get());
            switch (questionNumber)
            {
                //excerise 1
                case 1:
                    myView.Say("Please enter the marks");
                    int mark = int.Parse(myView.Get());
                    myView.Say(myModel.CheckMark(mark));
                    myView.Wait();
                break;

                //Excersie 2
                case 2:
                    myView.Say("Please enter the Number");
                    int number = int.Parse(myView.Get());
                    myView.Say(exTwoModel.checkNumber(number));
                    myView.Wait();
                break;

                case 3:
                //Excerside 3
                    myView.Say("Please enter the Digit");
                    int digit = int.Parse(myView.Get());
                    myView.Say(exThreeModel.sayNumber(digit));
                    myView.Wait();
                break;

                case 4:
                    //Excerisie 4
                    int max = 100;
                    myView.Say("Calculate num between 1 to 100");
                    myView.Say(exFourModel.SumValue(max));
                    myView.Say(exFourModel.AvgValue(max));
                    myView.Wait();
                 break;
               case 5:
                    //Exceersie 5 While Do
                    int val = 100;
                    myView.Say("Calculate num between 1 to 100 using while do");
                    myView.Say(exFiveModel.addvalues(val));
                    myView.Say(exFiveModel.avgValues(val));
                    myView.Wait();
               break;

               case 6:
                    //Exceersie 6 While Do
                    int value = 100;
                    myView.Say("Calculate num between 1 to 100 using do while");
                    myView.Say(exSixModel.calualteValues(value));
                    myView.Say(exSixModel.avgCal(value));
                    myView.Wait();
               break;

                case 7:
                    //Exceersie 7 
                    myView.Say("Calculate num between 111 to 8989 using for loop");
                    int startValue = 111;
                    int endValue = 8989;
                    myView.Say(exSevenModel.getAddValue(startValue, endValue));
                    myView.Say(exSevenModel.getAvgValue(startValue, endValue));
                    myView.Wait();
                    break;
                case 8:
                    //Exceersie 8
                    myView.Say("Calcalate the odd numbers between 1 to 100");
                    int highest = 100;
                    myView.Say(exEightModel.calOddnum(highest));
                    myView.Say(exEightModel.GetAverage(highest));
                    myView.Wait();
                    break;

                case 9:
                    //Exceersie 9
                    myView.Say("Calcalate the odd numbers between 1 to 100");
                    int targetValue = 100;
                    myView.Say(exNinemodel.getNumbers(targetValue));
                    myView.Wait();
                    break;

                case 10:
                    myView.Say("Finding the square numnbers from 1 to 100");
                    int lowestNumber = 1;
                    int highestNumber = 100;
                    myView.Say(exTenModel.FindSquresRoot(lowestNumber, highestNumber));
                    myView.Wait();
                    break;
                case 11:
                    myView.Say("find the product numbers");
                    
                   
                    int endproduct = 14;
                   
                    for(int startProd = 10; startProd <= 14; startProd++)
                    {
                        myView.Say(exElevenModel.FindProducts(startProd));
                    }
                    
                    myView.Wait();
                    break;
                case 12:
                    break;
            }

        }
    }
}
