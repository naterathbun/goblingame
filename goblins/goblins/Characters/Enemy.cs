﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goblins.Characters
{
    public class Enemy
    {
        List<string> reactionText = new List<string>();
        List<string> attackText = new List<string>();
        public Random goblinRNG = new Random();
        public int hitPoints = 3;

        public Enemy()                           // Constructor
        {
            reactionText.Add("The goblin screams and jumps back, but continues to attack.");
            reactionText.Add("The goblin falls to the ground, but quickly scrambles back to his feet, snarling.");
            reactionText.Add("The goblin spits blood and howls, his eyes filled with hatred.");
            reactionText.Add("The goblin is dazed but quickly recovers.");
            reactionText.Add("Black blood oozes from behind the goblins patchwork armor, his breathing ragged.");

            attackText.Add("The goblin lunges at you, his rusty blade connecting under your arm for");
            attackText.Add("The goblin throws a vial of black liquid. It bursts on your shoulder, sizzling and burning you for");
            attackText.Add("The goblin swings his curved sword in a reckless arc, slicing your legs for");
            attackText.Add("The goblin dances in close and lurches suddenly, scratching and biting for");
            attackText.Add("The goblin screams a horrible battlecry and lashes out with a barbed whip for");
        }

        public void React()                      // Print I'm still alive message
        {
            Console.WriteLine($" {reactionText[goblinRNG.Next(0, 5)]}");
        }                   

        public void Attack(int damageDealt)      // Goblin Attacks Player
        {
            Console.WriteLine($"\n {attackText[goblinRNG.Next(1, 5)]} {damageDealt} damage!\n");
        }   

        public void TakeDamage(int damageIn)     // Goblin takes damage from player
        {
            hitPoints -= damageIn;
        }  

        public bool IsGoblinDead()               // Checks if golin is dead
        {
            if (hitPoints <= 0)
            {
                NewGoblin();
                return true;
            }
            return false;
        }            

        public void NewGoblin()                  // Creates a new Goblin
        {
            Console.WriteLine($" The goblin falls to the ground dead, but another rushes forward to take his place!");
            hitPoints = goblinRNG.Next(2, 8);
        }
    }
}
