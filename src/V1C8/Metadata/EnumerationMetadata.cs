
namespace sabatex.V1C8.Metadata
{
    public class EnumerationsMetadata<T>:V1C8COMObject where T:V1C8COMObject
    {
        public EnumerationsMetadata(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public int Count()=>MethodSruct<int>("Count");
        public T Get(int i) =>Method<T>("Get",i);
        public int  IndexOf(V1C8COMObject obj)=>MethodInt("IndexOf",obj);
        public T EmptyRef()=>Method<T>("EmptyRef"); 

        public T Find(string value)=>Method<T>("Find",value);
        public bool Contains(V1C8COMObject obj)=>MethodSruct<bool>("Contains",obj);

    }
}

