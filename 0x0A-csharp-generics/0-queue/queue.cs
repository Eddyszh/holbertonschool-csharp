using System;

///<summary>
/// Generic Queue class
///</summary>
class Queue<T>
{
    ///<summary>
    /// Method to check the type
    ///</summary>
    ///<return>
    /// the type of the class
    ///</return>
    public Type CheckType()
    {
        return typeof(T);
    }
}
