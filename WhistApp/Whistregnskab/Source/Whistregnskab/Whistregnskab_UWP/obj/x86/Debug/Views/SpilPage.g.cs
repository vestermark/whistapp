﻿#pragma checksum "C:\Users\vestermark\Source\Repos\UWP_Workshop\WhistApp\Whistregnskab\Source\Whistregnskab\Whistregnskab_UWP\Views\SpilPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A3259ED9D99610C24FAAA9B13B100453"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Whistregnskab_UWP.Views
{
    partial class SpilPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Int32 value)
            {
                obj.SelectedIndex = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class SpilPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISpilPage_Bindings
        {
            private global::Whistregnskab_UWP.Views.SpilPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj6;
            private global::Windows.UI.Xaml.Controls.FlipView obj13;
            private global::Windows.UI.Xaml.Controls.FlipView obj15;
            private global::Windows.UI.Xaml.Controls.TextBlock obj16;
            private global::Windows.UI.Xaml.Controls.TextBlock obj17;
            private global::Windows.UI.Xaml.Controls.TextBlock obj18;
            private global::Windows.UI.Xaml.Controls.TextBlock obj19;
            private global::Windows.UI.Xaml.Controls.FlipView obj21;
            private global::Windows.UI.Xaml.Controls.FlipView obj23;
            private global::Windows.UI.Xaml.Controls.FlipView obj25;
            private global::Windows.UI.Xaml.Controls.TextBlock obj26;
            private global::Windows.UI.Xaml.Controls.TextBlock obj27;
            private global::Windows.UI.Xaml.Controls.TextBlock obj28;
            private global::Windows.UI.Xaml.Controls.TextBlock obj29;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj31;

            private SpilPage_obj1_BindingsTracking bindingsTracking;

            public SpilPage_obj1_Bindings()
            {
                this.bindingsTracking = new SpilPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object param0, global::Windows.UI.Xaml.RoutedEventArgs param1) =>
                        {
                        this.dataRoot.ViewModel.Gem();
                        };
                        break;
                    case 13:
                        this.obj13 = (global::Windows.UI.Xaml.Controls.FlipView)target;
                        (this.obj13).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedIndexProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.Stik = (this.obj13).SelectedIndex;
                                }
                            });
                        break;
                    case 15:
                        this.obj15 = (global::Windows.UI.Xaml.Controls.FlipView)target;
                        (this.obj15).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedIndexProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.Makker = (this.obj15).SelectedIndex;
                                }
                            });
                        break;
                    case 16:
                        this.obj16 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 17:
                        this.obj17 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 18:
                        this.obj18 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 19:
                        this.obj19 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 21:
                        this.obj21 = (global::Windows.UI.Xaml.Controls.FlipView)target;
                        (this.obj21).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedIndexProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.Skæve = (this.obj21).SelectedIndex;
                                }
                            });
                        break;
                    case 23:
                        this.obj23 = (global::Windows.UI.Xaml.Controls.FlipView)target;
                        (this.obj23).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedIndexProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.Melding = (this.obj23).SelectedIndex;
                                }
                            });
                        break;
                    case 25:
                        this.obj25 = (global::Windows.UI.Xaml.Controls.FlipView)target;
                        (this.obj25).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedIndexProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.Melder = (this.obj25).SelectedIndex;
                                }
                            });
                        break;
                    case 26:
                        this.obj26 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 27:
                        this.obj27 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 28:
                        this.obj28 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 29:
                        this.obj29 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 31:
                        this.obj31 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += (global::System.Object param0, global::Windows.UI.Xaml.RoutedEventArgs param1) =>
                        {
                        this.dataRoot.ViewModel.Slet();
                        };
                        break;
                    default:
                        break;
                }
            }

            // ISpilPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // SpilPage_obj1_Bindings

            public void SetDataRoot(global::Whistregnskab_UWP.Views.SpilPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Whistregnskab_UWP.Views.SpilPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::Whistregnskab_UWP.ViewModels.SpilPageViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Stik(obj.Stik, phase);
                        this.Update_ViewModel_Makker(obj.Makker, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Pulje(obj.Pulje, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Skæve(obj.Skæve, phase);
                        this.Update_ViewModel_Melding(obj.Melding, phase);
                        this.Update_ViewModel_Melder(obj.Melder, phase);
                    }
                }
            }
            private void Update_ViewModel_Stik(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj13, obj);
                }
            }
            private void Update_ViewModel_Makker(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj15, obj);
                }
            }
            private void Update_ViewModel_Pulje(global::Whistregnskab_UWP.Models.Pulje obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Pulje_Spiller1(obj.Spiller1, phase);
                        this.Update_ViewModel_Pulje_Spiller2(obj.Spiller2, phase);
                        this.Update_ViewModel_Pulje_Spiller3(obj.Spiller3, phase);
                        this.Update_ViewModel_Pulje_Spiller4(obj.Spiller4, phase);
                    }
                }
            }
            private void Update_ViewModel_Pulje_Spiller1(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj16, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj26, obj, null);
                }
            }
            private void Update_ViewModel_Pulje_Spiller2(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj17, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj27, obj, null);
                }
            }
            private void Update_ViewModel_Pulje_Spiller3(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj18, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj28, obj, null);
                }
            }
            private void Update_ViewModel_Pulje_Spiller4(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj19, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj29, obj, null);
                }
            }
            private void Update_ViewModel_Skæve(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj21, obj);
                }
            }
            private void Update_ViewModel_Melding(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj23, obj);
                }
            }
            private void Update_ViewModel_Melder(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj25, obj);
                }
            }

            private class SpilPage_obj1_BindingsTracking
            {
                global::System.WeakReference<SpilPage_obj1_Bindings> WeakRefToBindingObj; 

                public SpilPage_obj1_BindingsTracking(SpilPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<SpilPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SpilPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Whistregnskab_UWP.ViewModels.SpilPageViewModel obj = sender as global::Whistregnskab_UWP.ViewModels.SpilPageViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_ViewModel_Stik(obj.Stik, DATA_CHANGED);
                                    bindings.Update_ViewModel_Makker(obj.Makker, DATA_CHANGED);
                                    bindings.Update_ViewModel_Skæve(obj.Skæve, DATA_CHANGED);
                                    bindings.Update_ViewModel_Melding(obj.Melding, DATA_CHANGED);
                                    bindings.Update_ViewModel_Melder(obj.Melder, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Stik":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Stik(obj.Stik, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Makker":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Makker(obj.Makker, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Skæve":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Skæve(obj.Skæve, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Melding":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Melding(obj.Melding, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Melder":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Melder(obj.Melder, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Whistregnskab_UWP.ViewModels.SpilPageViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::Whistregnskab_UWP.ViewModels.SpilPageViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.pageHeader = (global::Template10.Controls.PageHeader)(target);
                }
                break;
            case 3:
                {
                    this.Overskrift = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 4:
                {
                    this.SpilBorder = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 5:
                {
                    this.rpKnap = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 6:
                {
                    this.Send = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7:
                {
                    this.rpMelder = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 8:
                {
                    this.rpMelding = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 9:
                {
                    this.spSkæve = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 10:
                {
                    this.rpMakker = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 11:
                {
                    this.rpStik = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 12:
                {
                    this.Stik = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.fvStik = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                }
                break;
            case 14:
                {
                    this.Makker = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.fvMakker = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                }
                break;
            case 20:
                {
                    this.Skæve = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21:
                {
                    this.fvSkæve = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                }
                break;
            case 22:
                {
                    this.Melding = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23:
                {
                    this.fvMelding = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                }
                break;
            case 24:
                {
                    this.Melder = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 25:
                {
                    this.fvMelder = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                }
                break;
            case 30:
                {
                    this.txtOverskrift = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 31:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element31 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    SpilPage_obj1_Bindings bindings = new SpilPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

