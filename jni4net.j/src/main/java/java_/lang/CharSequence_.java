// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package java_.lang;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class CharSequence_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return java_.lang.CharSequence_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        java_.lang.CharSequence_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __CharSequence extends system.Object implements java.lang.CharSequence {
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String toString();
    
    @net.sf.jni4net.attributes.ClrMethod("(I)C")
    public native char charAt(int par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int length();
    
    @net.sf.jni4net.attributes.ClrMethod("(II)Ljava/lang/CharSequence;")
    public native java.lang.CharSequence subSequence(int par0, int par1);
}
//</generated-proxy>