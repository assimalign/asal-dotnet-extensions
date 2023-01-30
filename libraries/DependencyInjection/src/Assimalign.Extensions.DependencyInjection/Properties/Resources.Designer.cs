﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assimalign.Extensions.DependencyInjection.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal partial class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Assimalign.Extensions.DependencyInjection.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to activate type &apos;{0}&apos;. The following constructors are ambiguous:.
        /// </summary>
        internal static string AmbiguousConstructorException {
            get {
                return ResourceManager.GetString("AmbiguousConstructorException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple constructors accepting all given argument types have been found in type &apos;{0}&apos;. There should only be one applicable constructor..
        /// </summary>
        internal static string AmbiguousConstructorMatch {
            get {
                return ResourceManager.GetString("AmbiguousConstructorMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arity of open generic service type &apos;{0}&apos; does not equal arity of open generic implementation type &apos;{1}&apos;..
        /// </summary>
        internal static string ArityOfOpenGenericServiceNotEqualArityOfOpenGenericImplementation {
            get {
                return ResourceManager.GetString("ArityOfOpenGenericServiceNotEqualArityOfOpenGenericImplementation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; type only implements IAsyncDisposable. Use DisposeAsync to dispose the container..
        /// </summary>
        internal static string AsyncDisposableServiceDispose {
            get {
                return ResourceManager.GetString("AsyncDisposableServiceDispose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call site type {0} is not supported.
        /// </summary>
        internal static string CallSiteTypeNotSupported {
            get {
                return ResourceManager.GetString("CallSiteTypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instances of abstract classes cannot be created..
        /// </summary>
        internal static string CannotCreateAbstractClasses {
            get {
                return ResourceManager.GetString("CannotCreateAbstractClasses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to resolve service for type &apos;{0}&apos; while attempting to activate &apos;{1}&apos;..
        /// </summary>
        internal static string CannotResolveService {
            get {
                return ResourceManager.GetString("CannotResolveService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to resolve service for type &apos;{0}&apos; while attempting to activate &apos;{1}&apos;..
        /// </summary>
        internal static string CannotResolveService1 {
            get {
                return ResourceManager.GetString("CannotResolveService1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A circular dependency was detected for the service of type &apos;{0}&apos;..
        /// </summary>
        internal static string CircularDependencyException {
            get {
                return ResourceManager.GetString("CircularDependencyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Constant value of type &apos;{0}&apos; can&apos;t be converted to service type &apos;{1}&apos;.
        /// </summary>
        internal static string ConstantCantBeConvertedToServiceType {
            get {
                return ResourceManager.GetString("ConstantCantBeConvertedToServiceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A suitable constructor for type &apos;{0}&apos; could not be located. Ensure the type is concrete and all parameters of a public constructor are either registered as services or passed as arguments. Also ensure no extraneous arguments are provided..
        /// </summary>
        internal static string CtorNotLocated {
            get {
                return ResourceManager.GetString("CtorNotLocated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot resolve {1} service &apos;{0}&apos; from root provider..
        /// </summary>
        internal static string DirectScopedResolvedFromRootException {
            get {
                return ResourceManager.GetString("DirectScopedResolvedFromRootException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GetCaptureDisposable call is supported only for main scope.
        /// </summary>
        internal static string GetCaptureDisposableNotSupported {
            get {
                return ResourceManager.GetString("GetCaptureDisposableNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Implementation type &apos;{0}&apos; can&apos;t be converted to service type &apos;{1}&apos;.
        /// </summary>
        internal static string ImplementationTypeCantBeConvertedToServiceType {
            get {
                return ResourceManager.GetString("ImplementationTypeCantBeConvertedToServiceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid service descriptor.
        /// </summary>
        internal static string InvalidServiceDescriptor {
            get {
                return ResourceManager.GetString("InvalidServiceDescriptor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Constructor marked with {0} does not accept all given argument types..
        /// </summary>
        internal static string MarkedCtorMissingArgumentTypes {
            get {
                return ResourceManager.GetString("MarkedCtorMissingArgumentTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple constructors accepting all given argument types have been found in type &apos;{0}&apos;. There should only be one applicable constructor..
        /// </summary>
        internal static string MultipleCtorsFound {
            get {
                return ResourceManager.GetString("MultipleCtorsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple constructors for type &apos;{0}&apos; were found with length {1}..
        /// </summary>
        internal static string MultipleCtorsFoundWithBestLength {
            get {
                return ResourceManager.GetString("MultipleCtorsFoundWithBestLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple constructors were marked with {0}..
        /// </summary>
        internal static string MultipleCtorsMarkedWithAttribute {
            get {
                return ResourceManager.GetString("MultipleCtorsMarkedWithAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A suitable constructor for type &apos;{0}&apos; could not be located. Ensure the type is concrete and services are registered for all parameters of a public constructor..
        /// </summary>
        internal static string NoConstructorMatch {
            get {
                return ResourceManager.GetString("NoConstructorMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A suitable constructor for type &apos;{0}&apos; could not be located. Ensure the type is concrete and services are registered for all parameters of a public constructor..
        /// </summary>
        internal static string NoConstructorMatch1 {
            get {
                return ResourceManager.GetString("NoConstructorMatch1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No service for type &apos;{0}&apos; has been registered..
        /// </summary>
        internal static string NoServiceRegistered {
            get {
                return ResourceManager.GetString("NoServiceRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open generic service type &apos;{0}&apos; requires registering an open generic implementation type..
        /// </summary>
        internal static string OpenGenericServiceRequiresOpenGenericImplementation {
            get {
                return ResourceManager.GetString("OpenGenericServiceRequiresOpenGenericImplementation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot consume {2} service &apos;{0}&apos; from {3} &apos;{1}&apos;..
        /// </summary>
        internal static string ScopedInSingletonException {
            get {
                return ResourceManager.GetString("ScopedInSingletonException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot resolve &apos;{0}&apos; from root provider because it requires {2} service &apos;{1}&apos;..
        /// </summary>
        internal static string ScopedResolvedFromRootException {
            get {
                return ResourceManager.GetString("ScopedResolvedFromRootException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service collection cannot be modified because it is read-only..
        /// </summary>
        internal static string ServiceCollectionReadOnly {
            get {
                return ResourceManager.GetString("ServiceCollectionReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Requested service descriptor doesn&apos;t exist..
        /// </summary>
        internal static string ServiceDescriptorNotExist {
            get {
                return ResourceManager.GetString("ServiceDescriptorNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generic implementation type &apos;{0}&apos; has a DynamicallyAccessedMembers attribute applied to a generic argument type, but the service type &apos;{1}&apos; doesn&apos;t have a matching DynamicallyAccessedMembers attribute on its generic argument type..
        /// </summary>
        internal static string TrimmingAnnotationsDoNotMatch {
            get {
                return ResourceManager.GetString("TrimmingAnnotationsDoNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generic implementation type &apos;{0}&apos; has a DefaultConstructorConstraint (&apos;new()&apos; constraint), but the generic service type &apos;{1}&apos; doesn&apos;t..
        /// </summary>
        internal static string TrimmingAnnotationsDoNotMatch_NewConstraint {
            get {
                return ResourceManager.GetString("TrimmingAnnotationsDoNotMatch_NewConstraint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Implementation type cannot be &apos;{0}&apos; because it is indistinguishable from other services registered for &apos;{1}&apos;..
        /// </summary>
        internal static string TryAddIndistinguishableTypeToEnumerable {
            get {
                return ResourceManager.GetString("TryAddIndistinguishableTypeToEnumerable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot instantiate implementation type &apos;{0}&apos; for service type &apos;{1}&apos;..
        /// </summary>
        internal static string TypeCannotBeActivated {
            get {
                return ResourceManager.GetString("TypeCannotBeActivated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No constructor for type &apos;{0}&apos; can be instantiated using services from the service container and default values..
        /// </summary>
        internal static string UnableToActivateTypeException {
            get {
                return ResourceManager.GetString("UnableToActivateTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to resolve service for type &apos;{0}&apos; while attempting to activate &apos;{1}&apos;..
        /// </summary>
        internal static string UnableToResolveService {
            get {
                return ResourceManager.GetString("UnableToResolveService", resourceCulture);
            }
        }
    }
}