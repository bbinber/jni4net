//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.runtime.rule {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Evaluator : global::java.io.Serializable {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/drools/runtime/rule/Operator;")]
        global::org.drools.runtime.rule.Operator getOperator();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isTemporal();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Evaluator_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.runtime.rule.@__Evaluator.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.runtime.rule.Evaluator), typeof(global::org.drools.runtime.rule.Evaluator_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.runtime.rule.Evaluator), typeof(global::org.drools.runtime.rule.Evaluator_))]
    internal sealed partial class @__Evaluator : global::java.lang.Object, global::org.drools.runtime.rule.Evaluator {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getOperator0;
        
        internal static global::net.sf.jni4net.jni.MethodId _isTemporal1;
        
        private @__Evaluator(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.runtime.rule.@__Evaluator.staticClass = @__class;
            global::org.drools.runtime.rule.@__Evaluator._getOperator0 = @__env.GetMethodID(global::org.drools.runtime.rule.@__Evaluator.staticClass, "getOperator", "()Lorg/drools/runtime/rule/Operator;");
            global::org.drools.runtime.rule.@__Evaluator._isTemporal1 = @__env.GetMethodID(global::org.drools.runtime.rule.@__Evaluator.staticClass, "isTemporal", "()Z");
        }
        
        public global::org.drools.runtime.rule.Operator getOperator() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.Operator>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.rule.@__Evaluator._getOperator0));
            }
        }
        
        public bool isTemporal() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::org.drools.runtime.rule.@__Evaluator._isTemporal1)));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Evaluator);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getOperator", "getOperator0", "()Lorg/drools/runtime/rule/Operator;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isTemporal", "isTemporal1", "()Z"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getOperator0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/runtime/rule/Operator;
            // ()Lorg/drools/runtime/rule/Operator;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.rule.Evaluator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.Evaluator>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.rule.Operator>(@__env, @__real.getOperator());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool isTemporal1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::org.drools.runtime.rule.Evaluator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.Evaluator>(@__env, @__obj);
            @__return = ((bool)(@__real.isTemporal()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.runtime.rule.@__Evaluator(@__env);
            }
        }
    }
    #endregion
}
