﻿namespace TurboCollections;

public class TurboBinarySearchTree<T>
{
    private static T[] nodes;

    public TurboBinarySearchTree(int size)
    {
        nodes = new T[size];
    }

    public int GetLeftChild(int n)
    {
        return n * 2 + 1;
    }

    public int GetRightChild(int n)
    {
        return n * 2 + 2;
    }

    public T GetValue(int n)
    {
        return nodes[n];
    }

    public void SetValue(int n, T value)
    {
        nodes[n] = value;
    }
}


