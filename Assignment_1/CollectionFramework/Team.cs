using System;
using System.Collections;

namespace CollectionFramework
{
    public class Team: IEnumerable
    {
        public Players[] team;
        int index;
        int size;
        public Team(int size)
        {
            team=new Players[size];
            this.size = size;
            index = 0;
        }

        public void AddPlayer(string name, int score)
        {
            if(index<size)
            {
                team[index] = new Players(name, score);
                index++;
            }
        }

        public IEnumerator GetEnumerator()
        {
           return team.GetEnumerator();
        }
    }
}
