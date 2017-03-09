using System;
using System.Collections.Generic;

public class School
{

    Dictionary<string, int> alunos = new Dictionary<string, int>();

    public void Add(string student, int grade)
    {
        // throw new NotImplementedException("You need to implement this function.");
        alunos.Add(student, grade);

    }

    public IEnumerable<string> Roster(int grade)
    {
        // throw new NotImplementedException("You need to implement this function.");

        List<string> allClassmate = new List<String>();

        foreach (KeyValuePair<string, int> aluno in alunos)
        {
            if (aluno.Value == grade)
                allClassmate.Add(aluno.Key);
        }

        allClassmate.Sort();

        return allClassmate;

    }

    public IEnumerable<string> Grade(int grade)
    {
        // throw new NotImplementedException("You need to implement this function.");

        List<String> listForSort = new List<String>();

        foreach (KeyValuePair<string, int> aluno in alunos)
        {
            if(aluno.Value == grade)
                listForSort.Add(aluno.Key);
        }

        listForSort.Sort();

        return listForSort;
    }
}