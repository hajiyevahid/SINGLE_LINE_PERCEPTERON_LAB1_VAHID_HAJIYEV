using System;
using System.Security.Cryptography.X509Certificates;
using Vahid_Hajiyev_Percepteron_Laboratory_Work_1;

namespace Vahid_Hajiyev_Percepteron_Laboratory_Work_1
{
    class SINGLE_LINE_PERCEPTERON
    {
        static void Main(string[] args)
        {
            double y;
            double[] weights = new double[2];
            double learningRate = 0.2;
            double bias;
            float weight;
            Double error;
            double[] errors = new double[8];
            float[] desiredOutput = { 1, 1, 1, 1, 1, -1, -1, -1 };
            float[] receviedOutput = new float[8];
            float output;
            double[] arr = new double[6];

            double[] apple1 = { 0.21835, 0.81884, 1 };
            double[] apple2 = { 0.14115, 0.83535, 1 };
            double[] apple3 = { 0.37022, 0.8111, 1 };
            double[] apple4 = { 0.31565, 0.83101, 1 };
            double[] apple5 = { 0.36484, 0.8518, 1 };
            double[] apple6 = { 0.46111, 0.82518, 1 };
            double[] apple7 = { 0.55223, 0.83449, 1 };
            double[] apple8 = { 0.16975, 0.84049, 1 };
            double[] apple9 = { 0.49187, 0.80889, 1 };
            double[] pear1 = { 0.14913, 0.77104, -1 };
            double[] pear2 = { 0.18474, 0.6279, -1 };
            double[] pear3 = { 0.08838, 0.62068, -1 };
            double[] pear4 = { 0.098166, 0.79092, -1 };

            //decision making and updating algorithms for single line percepteron

            int DECISION_MAKING_ALGORITHM(Double v)
            {

                if (v >= 0)
                {

                    return 1;
                }
                else
                {
                    return -1;
                }

            }


            float WEIGHT_UPDATING(float weight, float error, float input, float learningRate)
            {


                weight += learningRate * error * input;

                return weight;
            }


            float BIAS_UPDATING_(float bias, int error, float learningRate)
            {


                bias += learningRate * error;


                return bias;
            }
            // giving random numbers to w0, w1, and bias only 1 time 

            Random rnd0 = new Random();
            double random0 = rnd0.NextDouble();

            weights[0] = rnd0.NextDouble();
            Console.WriteLine("weight 0   = " + random0 + "               ");

            Random rnd1 = new Random();
            double random1 = rnd1.NextDouble();

            weights[1] = rnd1.NextDouble();
            Console.WriteLine("weight 1   = " + random1 + "               ");

            Random bs = new Random();
            bias = bs.NextDouble();
            Console.WriteLine("bias   = " + bias + "              ");

            //------------------------------------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------------------------------------

            double v;
            //starting calculation operations for apple1,apple2,apple3,apple4,apple5,pear1,pear2,pear3

            Console.WriteLine("**********APPLE 1****************");
            //Apple1***************************************************************************

            v = (apple1[0] * weights[0] + apple1[1] * weights[1] + bias);

            Console.WriteLine("v for apple 1 = " + v);

            output = DECISION_MAKING_ALGORITHM(v);
            Console.WriteLine("y for apple 1 = " + output);
            receviedOutput[0] = output;
            //*******************************************************************************
            Console.WriteLine("**********APPLE 2****************");

            //Apple2***************************************************************************

            v = (apple2[0] * weights[0] + apple2[1] * weights[1] + bias);

            Console.WriteLine("v for apple 2 = " + v);

            output = DECISION_MAKING_ALGORITHM(v);
            Console.WriteLine("y for apple 2 = " + output);
            receviedOutput[1] = output;
            //*******************************************************************************
            Console.WriteLine("**********APPLE 3****************");

            //Apple3***************************************************************************

            v = (apple3[0] * weights[0] + apple3[1] * weights[1] + bias);

            Console.WriteLine("v for apple 3 = " + v);

            output = DECISION_MAKING_ALGORITHM(v);
            Console.WriteLine("y for apple 3 = " + output);
            receviedOutput[2] = output;
            //*******************************************************************************
            Console.WriteLine("**********APPLE 4****************");

            //Apple4***************************************************************************

            v = (apple4[0] * weights[0] + apple4[1] * weights[1] + bias);

            Console.WriteLine("v for apple 4 = " + v);

            output = DECISION_MAKING_ALGORITHM(v);
            Console.WriteLine("y for apple 4 = " + output);
            receviedOutput[3] = output;
            //*******************************************************************************

            Console.WriteLine("**********APPLE 5****************");

            //Apple5***************************************************************************

            v = (apple5[0] * weights[0] + apple5[1] * weights[1] + bias);

            Console.WriteLine("v for apple 5 = " + v);

            output = DECISION_MAKING_ALGORITHM(v);
            Console.WriteLine("y for apple 5 = " + output);
            receviedOutput[4] = output;
            //*******************************************************************************


            Console.WriteLine("***************PEAR1******************");
            //Pear1**********************************************************************

            v = (pear1[0] * weights[0] + pear1[1] * weights[1] + bias);

            Console.WriteLine("v for pear1 = " + v);

            output = DECISION_MAKING_ALGORITHM(v);
            Console.WriteLine("y for pear1 = " + output);
            receviedOutput[5] = output;

            Console.WriteLine("***************PEAR2******************");
            //Pear2**********************************************************************

            v = (pear2[0] * weights[0] + pear2[1] * weights[1] + bias);

            Console.WriteLine("v for pear2 = " + v);

            output = DECISION_MAKING_ALGORITHM(v);
            Console.WriteLine("y for pear2 = " + output);
            receviedOutput[6] = output;


            Console.WriteLine("***************PEAR3******************");
            //Pear3**********************************************************************

            v = (pear3[0] * weights[0] + pear3[1] * weights[1] + bias);

            Console.WriteLine("v for pear3 = " + v);

            output = DECISION_MAKING_ALGORITHM(v);
            Console.WriteLine("y for pear3 = " + output);
            receviedOutput[7] = output;

            desiredOutput[0] = 1;
            desiredOutput[1] = 1;

            desiredOutput[2] = 1;
            desiredOutput[3] = 1;
            desiredOutput[4] = 1;
            desiredOutput[5] = -1;
            desiredOutput[6] = -1;
            desiredOutput[7] = -1;

            //gathering all elements of desiredOutput massive and send it to our screen
            Console.Write("desired output [ ");
            for(int i = 0; i < 8; i++)
            {
                Console.Write(desiredOutput[i]+",");
            }
            Console.Write("] ");

            Console.WriteLine("");

            //gathering all elements of receivedOutput massive and send it to our screen

            Console.Write("received output; ");
            Console.Write("[");
            for (int j = 0; j < 8; j++)
            {
                Console.Write(receviedOutput[j] + ",");
            }
            Console.Write("]");
            //--------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");


             //checking and detecting errors and training them

            for (int z = 0; z < 8; z++)
            {
                errors[z] = desiredOutput[z] - receviedOutput[z];// find which fruit has error 

                if (errors[z] != 0)
                {
                    Console.Write((z + 1)+ " th fruit has error    "); //detecting error for appropriate fruit
                    Console.WriteLine("");

                    if ((z + 1) == 6)//program decided that this fruit is pear 1
                    {
                        
                       
                            weights[0] = random0;
                            weights[1] = random1;

                        while (v> 0) // because program decided that it is pear1 and it's "v" must be below 0. Training v while v>0
                        {


                            weights[0] = weights[0] + learningRate * errors[z] * pear1[0]; //updating w0


                            weights[1] = weights[1] + learningRate * errors[z] * pear1[1];//updating w1


                            bias = bias + learningRate * errors[z];//updating bias


                            v = (pear1[0] * weights[0] + pear1[1] * weights[1] + bias);// calculating last value of v for pear1
                            //if v>0, it starts again to train our initial w0, w1, and bias
                           
                        }

                        if (v < 0)//if our trained elements are correct, it means that our v for pears will be: v<0
                        {
                           
                            errors[z] = 0; //changing error value of "errors" massive's elements which values gained from training (0)
                            receviedOutput[z] = -1; //changing appropriate receivedOutput value to correct one

                            //sending values to screen
                            Console.WriteLine("updated universal weight 0:  "+weights[0]);
                            Console.WriteLine("updated universal  weight 1:  " + weights[1]);
                            Console.WriteLine("updated bias:  " + bias);
                            Console.WriteLine("v for pear 1:     " + v);

                            Console.WriteLine("Final error value for Pear 1 is : " + errors[z]);
                            Console.WriteLine("---------------------------------------------------------------------");


                        }

                    }
                   
                    if ((z + 1) == 7)// program decided that this fruit is pear 2
                    {

                            v = (pear2[0] * weights[0] + pear2[1] * weights[1] + bias); //calculating last value of v for pear2

                        if (v < 0)
                        {
                            receviedOutput[z] = -1;

                            errors[z] = 0;

                            //sending values to screen
                            Console.WriteLine("updated universal weight 0:  " + weights[0]);
                            Console.WriteLine("updated universal weight 1:  " + weights[1]);
                            Console.WriteLine("updated bias:  " + bias);
                            Console.WriteLine("v for pear 2:     " + v);

                            Console.WriteLine("Final error value for Pear 2 is : " + errors[z]);
                            Console.WriteLine("---------------------------------------------------------------------");


                        }


                    }


                    if ((z + 1) == 8)//program decided that this fruit is pear 3
                    {
                       
                        v = (pear3[0] * weights[0] + pear3[1] * weights[1] + bias); //calculating last value of v for pear3



                        if (v < 0)
                        {
                            receviedOutput[z] = -1;

                            errors[z] = 0;
                            //sending values to screen
                            Console.WriteLine("updated universal  weight 0:  " + weights[0]);
                            Console.WriteLine("updated universal  weight 1:  " + weights[1]);
                            Console.WriteLine("updated bias:  " + bias);
                            Console.WriteLine("v for pear 3:     " + v);

                            Console.WriteLine("Final error value for Pear 3 is : " + errors[z]);
                            Console.WriteLine("---------------------------------------------------------------------");



                        }

                    }

                }
            }
            Console.WriteLine("*********************************************************************************************************");

            //sending elements of error array to screen
            Console.Write("Elements of error array :  [");
               for(int i = 0; i < 8; i++)
               {
                Console.Write(errors[i]+",");
               }

            Console.WriteLine("]");

            //sending final elements of receivedOutput array to screen
              Console.Write("Final Received output array :  [");
               for(int i = 0; i < 8; i++)
               {
                Console.Write(receviedOutput[i]+",");
               }

            Console.WriteLine("]");

        }

    }//***********************END OF SINGLE LINE PERCEPTERON TRAINING LABORATORY WORK 1 OF VAHID HAJIYEV**********************************
}
