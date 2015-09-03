﻿#pragma checksum "C:\Users\Javier\Documents\GitHub\Events\TLP Innova 2015\Taller\Ejemplo\04. Final\FormulaOne\FormulaOne\Views\MainView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6482052A6B4503036B9661B26CAB01E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormulaOne.Views
{
    partial class MainView : 
        global::FormulaOne.Views.Base.PageBase, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            static bool shouldUpdate(int expectedPhase, int currentPhase)
            {
                return (currentPhase == -1 || currentPhase == expectedPhase);
            }
                  
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                            value = targetNullValue;
                    }
                    obj.Text = value;
                }
            public static void Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(global::Windows.UI.Xaml.Controls.FontIcon obj, global::System.String value, string targetNullValue)
                {
                    if (value == null && targetNullValue != null)
                    {
                            value = targetNullValue;
                    }
                    obj.Glyph = value;
                }
        };

        private class MainView_obj1_Bindings : 
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainView_Bindings
        {
            private global::FormulaOne.Models.MenuItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = -2;
            private const int DATA_CHANGED = -1;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj2;
            private global::Windows.UI.Xaml.Controls.FontIcon obj3;

            public MainView_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.FontIcon)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::FormulaOne.Models.MenuItem data = args.NewValue as global::FormulaOne.Models.MenuItem;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::FormulaOne.Models.MenuItem was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IMainView_Bindings

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
            }

            // MainView_obj1_Bindings

            public void SetDataRoot(global::FormulaOne.Models.MenuItem newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::FormulaOne.Models.MenuItem obj, int phase)
            {
                if (obj != null)
                {
                    if (phase == NOT_PHASED || phase == 0)
                    {
                        this.Update_Title(obj.Title, phase);
                        this.Update_Icon(obj.Icon, phase);
                    }
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj2, (global::System.String)((global::Windows.UI.Xaml.Data.IValueConverter)global::Windows.UI.Xaml.Application.Current.Resources["ToUpperConverter"]).Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_Icon(global::System.String obj, int phase)
            {
                if (phase == NOT_PHASED || phase == 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(this.obj3, obj, null);
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
            case 4:
                {
                    this.wideState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.narrowState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6:
                {
                    this.mobile = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 7:
                {
                    this.Splitter = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 8:
                {
                    this.HamburguerButton = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                }
                break;
            case 9:
                {
                    this.Hamburger = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                }
                break;
            case 10:
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 11:
                {
                    this.MenuList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 12:
                {
                    this.SplitViewFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
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
                    global::Windows.UI.Xaml.Controls.Grid element1 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    MainView_obj1_Bindings bindings = new MainView_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::FormulaOne.Models.MenuItem) element1.DataContext);                
                      element1.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
