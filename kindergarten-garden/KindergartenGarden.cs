using System;
using System.Collections.Generic;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class Garden
{
    private List<string> children;
    private string windowSills;
    public Garden(IEnumerable<string> children, string windowSills)
    {
        this.children = new List<string> (children);
        this.windowSills = windowSills;
    }

    public IEnumerable<Plant> GetPlants(string child)
    {
        // throw new NotImplementedException("You need to implement this function.");

        string plantsText = "";
        List <Plant> plants = new List<Plant>();
        
        this.children.Sort();

        for (int i = 0; i < this.children.Count; i++)
        {
            if (this.children[i].Equals(child))
            {       
                    int posicao = 0;
                    int posicao2 =0;
                    if(i > 0)
                        posicao = i * 2;

                    if(this.windowSills.Length >= 5)
                        posicao2 = this.windowSills.IndexOf("\n") + 1;
                    
                    if(i > 0)
                        posicao2 += i * 2;

                    plantsText = this.windowSills.Substring(posicao, 2);
                    plantsText += this.windowSills.Substring(posicao2,2);
                    break;
            }
        }
        
        foreach(char firstLetterPlant in plantsText){
            if(firstLetterPlant == 'V')
                plants.Add(Plant.Violets);
            else if(firstLetterPlant == 'R')
                plants.Add(Plant.Radishes);
            else if(firstLetterPlant == 'C')
                plants.Add(Plant.Clover);
            else if(firstLetterPlant == 'G')
                plants.Add(Plant.Grass);
        }

        return plants.ToArray();
    }


    public static Garden DefaultGarden(string windowSills)
    {
        // throw new NotImplementedException("You need to implement this function.");
        List<string> children = new List<string>();

        children.Add("Alice");
        children.Add("Bob");
        children.Add("Charlie");
        children.Add("David");
        children.Add("Eve");
        children.Add("Fred");
        children.Add("Ginny");
        children.Add("Harriet");
        children.Add("Ileana");
        children.Add("Joseph");
        children.Add("Kincaid");
        children.Add("Larry");

        Garden garden = new Garden(children, windowSills);
        return garden;
    }
}