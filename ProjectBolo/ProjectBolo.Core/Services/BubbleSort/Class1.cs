using System.Collections.Generic;

namespace ProjectBolo.Core.Services.BubbleSort
{
    internal class DoBubbleSort
    {
        public static List<string> BubbleSort(List<string> vetor)
        {
            string aux;

            for (int i = 0; i < vetor.Count; i++)
            {
                if (vetor[i + 1].CompareTo(vetor[i]) < 0)
                {
                    aux = vetor[i];
                    vetor[i] = vetor[i + i];
                    vetor[i + 1] = aux;
                }
            }

            return vetor;
        }
    }
}
