using Blockcore.Networks;

namespace CyBits.Networks
{
   public static class Networks
   {
      public static NetworksSelector CyBits
      {
         get
         {
            return new NetworksSelector(() => new CyBitsMain(), () => new CyBitsTest(), () => new CyBitsRegTest());
         }
      }
   }
}
