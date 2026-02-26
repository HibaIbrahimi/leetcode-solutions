/*un tableau de taille n + 1 où on a tous les éléments entre 1 et n.
Ecrire une fonction qui prend en param le tableau en question et
 retourne la valeur du doublon.*/

public int FindDoublon ( int[] input)
{
    HashSet<int> set = new HashSet<int>();

    // Remplissage
    for( int i= 0; i< input.Length ; i++)
    {
        if ( set.Contains(input[i]))
        {
            return input[i];
        }
        set.Add(input[i]);
    }
    return -1;
}