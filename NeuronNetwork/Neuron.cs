using System;
using System.Collections.Generic;


namespace NeuronNetwork
{
    public class Neuron
    {
        public List<double> weights { get; }
        public NeuronTypes neuronType { get; }
        public double neuronOutput { get; private set; }

        public Neuron(int countNeuron,NeuronTypes type = NeuronTypes.Hidden)
        {
            neuronType = type;
            weights = new List<double>();
            for(int i = 0;i<weights.Count;i++)
            {
                weights.Add(1);
            }
        }

        public double FeedForward(List<double> inputs)
        {
            var sum = 0.0;
            for (int i = 0;i<inputs.Count;i++)
            {
                sum += inputs[i] * weights[i];
            }
            if (neuronType != NeuronTypes.Input)
                neuronOutput = Sigmoida(sum);
            else
                neuronOutput = sum;
            return neuronOutput;
        }

        public void SetWeights(params double[] weightsNeuron)
        {
            for (int i =0;i<weightsNeuron.Length;i++)
            {
                weights[i] = weightsNeuron[i];
            }
        }

        public double Sigmoida(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }

        public override string ToString()
        {
            return neuronOutput.ToString();
        }
    }
}
