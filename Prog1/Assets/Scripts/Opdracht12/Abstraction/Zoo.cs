using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    Animal[] animal = { new Bird(), new Dog(), new Elephant() };
    private void Start()
    {
        foreach (Animal anim in animal)
        {
            anim.eat();
            anim.move();
        }
    }
}

public abstract class Animal : MonoBehaviour
{
    public abstract void move();
    public void eat()
    {
        Debug.Log("namanananana");    
    }
  
}

public class Bird : Animal
{
    public override void move()
    {
        Debug.Log("Flying away weeeee");
    }
}

public class Elephant : Animal
{
    public override void move()
    {
        Debug.Log("Runs away");
    }
}

public class Dog : Animal
{
    public override void move()
    {
        Debug.Log("climbing a tree");
    }
}


