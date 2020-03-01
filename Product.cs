using System.Runtime.Serialization;

namespace Business_Logic
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public double price;
        [DataMember]
        public int size;
        [DataMember]
        public string name;
        public string displayProduct()
        {
            return ($"{name} costs {price}  weighs {size} kg \n");
        }
    }
}