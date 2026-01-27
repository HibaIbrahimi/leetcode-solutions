public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int write = 0;

        // 1) Déplacer les non-zéros au début
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[write] = nums[i];
                write++;
            }
        }

        // 2) Remplir le reste avec des zéros
        for (int i = write; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}

// explication

// Méthode la plus claire (Two Pointers)

// On utilise 1 pointeur d’écriture :
// write = index où placer le prochain non-zéro
// On parcourt le tableau avec i

// Étapes:
// Parcourir tout le tableau
// À chaque non-zéro, l’écrire à nums[write], puis write++
// Après la boucle, remplir de 0 de write jusqu’à la fin
