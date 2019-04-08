namespace Dataifx.Trading.Activity {
    
    #line 26 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PlacementOrderActivity.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PlacementOrderActivity.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 27 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PlacementOrderActivity.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PlacementOrderActivity.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PlacementOrderActivity.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PlacementOrderActivity.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 28 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PlacementOrderActivity.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 29 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PlacementOrderActivity.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 30 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PlacementOrderActivity.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 31 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PlacementOrderActivity.xaml"
    using Dataifx.Trading.Infrastructure.Models;
    
    #line default
    #line hidden
    
    #line 32 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PlacementOrderActivity.xaml"
    using Dataifx.Trading.CommonObjects;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PlacementOrderActivity.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class PlacementOrderActivity : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext0 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext1 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext2 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext3 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext4 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<string>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext5 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext6 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext6.GetLocation<Dataifx.Trading.CommonObjects.PerfilUsuario>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext7 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext8 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext8.GetLocation<Dataifx.Trading.CommonObjects.Orden>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext9 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext10 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext11 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext11.GetLocation<Dataifx.Trading.Infrastructure.Models.Error>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext12 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext12.GetLocation<int>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext13 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext13.GetLocation<string>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext14 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext14.GetLocation<bool>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext15 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext16 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext17 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext17.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext18 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext19 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext20 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext20.GetLocation<bool>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext21 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext22 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext23 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext23.GetLocation<Dataifx.Trading.Infrastructure.Models.Error>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext24 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext25 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext25.GetLocation<int>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext26 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext26.GetLocation<string>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext27 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext27.GetLocation<bool>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext28 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext28.GetLocation<int>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext29 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext29.GetLocation<string>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext30 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext31 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext32 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext32.GetLocation<string>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext33 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext34 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext34.GetLocation<Dataifx.Trading.CommonObjects.TipoDocumento>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext35 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext36 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext36.GetLocation<string>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext37 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext38 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext39 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext39.GetLocation<bool>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext40 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext41 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext42 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext42.GetLocation<Dataifx.Trading.Infrastructure.Models.Error>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext43 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext43.GetLocation<int>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext44 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext44.GetLocation<string>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext45 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext45.GetLocation<bool>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext46 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext47 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext48 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext48.GetLocation<string>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext49 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext50 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext50.GetLocation<int>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext51 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext52 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext52.GetLocation<Dataifx.Trading.Infrastructure.Models.StateOrder>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext53 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext54 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext54.GetLocation<Dataifx.Trading.Infrastructure.Models.Error>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext55 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext55.GetLocation<bool>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext56 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext57 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext58 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext59 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext59.GetLocation<bool>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext60 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext61 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext61.GetLocation<bool>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext62 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext63 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext64 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext64.GetLocation<bool>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext65 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext66 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext66.GetLocation<bool>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext67 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext68 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext68.GetLocation<bool>(refDataContext68.ValueType___Expr68Get, refDataContext68.ValueType___Expr68Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext69 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext69.GetLocation<bool>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext70 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext71 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext72 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext72.GetLocation<bool>(refDataContext72.ValueType___Expr72Get, refDataContext72.ValueType___Expr72Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext73 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext74 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext74.GetLocation<bool>(refDataContext74.ValueType___Expr74Get, refDataContext74.ValueType___Expr74Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext75 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext75.ValueType___Expr75Get();
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext76 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext77 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext77.GetLocation<Dataifx.Trading.Infrastructure.Models.Error>(refDataContext77.ValueType___Expr77Get, refDataContext77.ValueType___Expr77Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext78 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext78.GetLocation<int>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext79 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext79.GetLocation<bool>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext80 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext80.GetLocation<string>(refDataContext80.ValueType___Expr80Get, refDataContext80.ValueType___Expr80Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext81 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext81.ValueType___Expr81Get();
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext82 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext82.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext82.ValueType___Expr82Get, refDataContext82.ValueType___Expr82Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext83 = ((PlacementOrderActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PlacementOrderActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PlacementOrderActivity_TypedDataContext2(locations, activityContext, true);
                }
                PlacementOrderActivity_TypedDataContext2 refDataContext84 = ((PlacementOrderActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext84.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set, expressionId, this.rootActivity, activityContext);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext0 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext1 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext2 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext2.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext3 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext4 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<string>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext5 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext6 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext6.GetLocation<Dataifx.Trading.CommonObjects.PerfilUsuario>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext7 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext8 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext8.GetLocation<Dataifx.Trading.CommonObjects.Orden>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext9 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext10 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext11 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext11.GetLocation<Dataifx.Trading.Infrastructure.Models.Error>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext12 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext12.GetLocation<int>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext13 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext13.GetLocation<string>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext14 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext14.GetLocation<bool>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext15 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext16 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext17 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext17.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext18 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext19 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext20 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext20.GetLocation<bool>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set);
            }
            if ((expressionId == 21)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext21 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext22 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext23 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext23.GetLocation<Dataifx.Trading.Infrastructure.Models.Error>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set);
            }
            if ((expressionId == 24)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext24 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext25 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext25.GetLocation<int>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
            }
            if ((expressionId == 26)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext26 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext26.GetLocation<string>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext27 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext27.GetLocation<bool>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext28 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext28.GetLocation<int>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set);
            }
            if ((expressionId == 29)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext29 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext29.GetLocation<string>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext30 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext31 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext32 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext32.GetLocation<string>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
            }
            if ((expressionId == 33)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext33 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext34 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext34.GetLocation<Dataifx.Trading.CommonObjects.TipoDocumento>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set);
            }
            if ((expressionId == 35)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext35 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext36 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext36.GetLocation<string>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set);
            }
            if ((expressionId == 37)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext37 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext38 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext39 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext39.GetLocation<bool>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set);
            }
            if ((expressionId == 40)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext40 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext41 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext42 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext42.GetLocation<Dataifx.Trading.Infrastructure.Models.Error>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext43 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext43.GetLocation<int>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set);
            }
            if ((expressionId == 44)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext44 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext44.GetLocation<string>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set);
            }
            if ((expressionId == 45)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext45 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext45.GetLocation<bool>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set);
            }
            if ((expressionId == 46)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext46 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext47 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext48 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext48.GetLocation<string>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set);
            }
            if ((expressionId == 49)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext49 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext50 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext50.GetLocation<int>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set);
            }
            if ((expressionId == 51)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext51 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext52 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext52.GetLocation<Dataifx.Trading.Infrastructure.Models.StateOrder>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set);
            }
            if ((expressionId == 53)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext53 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext54 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext54.GetLocation<Dataifx.Trading.Infrastructure.Models.Error>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set);
            }
            if ((expressionId == 55)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext55 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext55.GetLocation<bool>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set);
            }
            if ((expressionId == 56)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext56 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext57 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext58 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext59 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext59.GetLocation<bool>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
            }
            if ((expressionId == 60)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext60 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext61 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext61.GetLocation<bool>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
            }
            if ((expressionId == 62)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext62 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext63 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext64 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext64.GetLocation<bool>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set);
            }
            if ((expressionId == 65)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext65 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext66 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext66.GetLocation<bool>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set);
            }
            if ((expressionId == 67)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext67 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext68 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext68.GetLocation<bool>(refDataContext68.ValueType___Expr68Get, refDataContext68.ValueType___Expr68Set);
            }
            if ((expressionId == 69)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext69 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext69.GetLocation<bool>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set);
            }
            if ((expressionId == 70)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext70 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext71 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext72 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext72.GetLocation<bool>(refDataContext72.ValueType___Expr72Get, refDataContext72.ValueType___Expr72Set);
            }
            if ((expressionId == 73)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext73 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext74 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext74.GetLocation<bool>(refDataContext74.ValueType___Expr74Get, refDataContext74.ValueType___Expr74Set);
            }
            if ((expressionId == 75)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext75 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext75.ValueType___Expr75Get();
            }
            if ((expressionId == 76)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext76 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext77 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext77.GetLocation<Dataifx.Trading.Infrastructure.Models.Error>(refDataContext77.ValueType___Expr77Get, refDataContext77.ValueType___Expr77Set);
            }
            if ((expressionId == 78)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext78 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext78.GetLocation<int>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set);
            }
            if ((expressionId == 79)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext79 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext79.GetLocation<bool>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set);
            }
            if ((expressionId == 80)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext80 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext80.GetLocation<string>(refDataContext80.ValueType___Expr80Get, refDataContext80.ValueType___Expr80Set);
            }
            if ((expressionId == 81)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext81 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext81.ValueType___Expr81Get();
            }
            if ((expressionId == 82)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext82 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext82.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext82.ValueType___Expr82Get, refDataContext82.ValueType___Expr82Set);
            }
            if ((expressionId == 83)) {
                PlacementOrderActivity_TypedDataContext2_ForReadOnly valDataContext83 = new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                PlacementOrderActivity_TypedDataContext2 refDataContext84 = new PlacementOrderActivity_TypedDataContext2(locations, true);
                return refDataContext84.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new InfoUsuario() { InfoCliente = new InfoCliente { Id = MyNewOrder.Client.Id } }" +
                            "") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "usuarioWeb") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "MyNewOrder.Client.OriginatorId") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "usuarioWeb.Id") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Dataifx.Trading.Business.Converter.ConvertProfile.ObtenerPerfil(MyNewOrder.Origin" +
                            "atorOrder.Profile)") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "usuarioWeb.Perfil") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.FillOrder(MyNewOrder, usuarioWeb)") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyOrder") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "usuarioWeb != null") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Error()") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService.Code") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService.Description") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService.existError") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.ObtenerDatosCuentaporWinsiob(usuarioWeb.InfoCliente.Id)") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "usuarioAux") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "usuarioWeb.Perfil == PerfilUsuario.TraderSoporte") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.ValidarDatosCliente(MyOrder,usuarioWeb,MontoMaximoValido,usuarioAu" +
                            "x)") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ClienteValido") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ClienteValido") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Infrastructure.Models.Error()") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!MontoMaximoValido") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService.Code") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService.Description") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService.existError") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService.Code") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService.Description") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "usuarioAux.InfoCliente.NumeroDocumento") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "usuarioWeb.InfoCliente.NumeroDocumento") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "usuarioAux.InfoCliente.TipoDoc") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "usuarioWeb.InfoCliente.TipoDoc") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "usuarioAux.UsuarioSoporte") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "usuarioWeb.UsuarioSoporte") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "usuarioWeb.Perfil == PerfilUsuario.TraderSoporte") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.Cursar(MyOrder, usuarioWeb , MyNewOrder.Client.ClientIp)") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "resultado") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "resultado") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Infrastructure.Models.Error()") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService.Code") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService.Description") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService.existError") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "MyOrder == null") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "MyNewOrder.Client.Name") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.Username") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Convert.ToInt32(MyOrder.Id)") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.Id") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "StateOrder.Sent") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.StateOrder") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Infrastructure.Models.Error()") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService.existError") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.CursarComercialCiti(MyOrder, usuarioWeb, MyNewOrder.Client.ClientI" +
                            "p)") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "resultado") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.CursarComercial(MyOrder,usuarioWeb,MyNewOrder.Client.ClientIp)") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "resultado") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "usuarioWeb.Perfil == PerfilUsuario.TraderSoporte") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.OrderRouting.Cursar(MyOrder, usuarioWeb, MyNewOrder.Client.Clie" +
                            "ntIp, \'1\')") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "resultado") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.OrderRouting.CursarComercial(MyOrder, usuarioWeb, MyNewOrder.Cl" +
                            "ient.ClientIp, \'1\')") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "resultado") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.ValidarDatosClienteComercial(MyOrder,usuarioWeb,MontoMaximoValido," +
                            "usuarioAux)") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ClienteValido") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MontoMaximoValido") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "MyNewOrder.Instrument.Type == Infrastructure.Enumerations.MarketType.Futures || M" +
                            "yNewOrder.Instrument.Type == Infrastructure.Enumerations.MarketType.Energy") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.OrderRouting.ValidarDatosCliente(MyOrder,usuarioWeb,MyOrder.Inf" +
                            "oCliente.Id.Replace(\',\',\'.\'), Business.Correval.User.ObtenerDatosCuenta(usuarioW" +
                            "eb.Id), MyNewOrder.Client)") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ClienteValido") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.OrderRouting.ValidarGarantias(MyNewOrder, usuarioWeb, Business." +
                            "Correval.User.ObtenerDatosCuenta(usuarioWeb.Id))") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ClienteValido") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ClienteValido") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Infrastructure.Models.Error()") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService.Code") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService.existError") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyNewOrder.ErrorService.Description") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new InfoUsuario()") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "usuarioWeb") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.ObtenerInformacionPorCliente(MyNewOrder.Client.Id)") 
                        && (PlacementOrderActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "usuarioWeb") 
                        && (PlacementOrderActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new PlacementOrderActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new PlacementOrderActivity_TypedDataContext2(locationReferences).@__Expr84GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PlacementOrderActivity_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PlacementOrderActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PlacementOrderActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PlacementOrderActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PlacementOrderActivity_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PlacementOrderActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PlacementOrderActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PlacementOrderActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PlacementOrderActivity_TypedDataContext1 : PlacementOrderActivity_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool resultado;
            
            protected int IdFirma;
            
            public PlacementOrderActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PlacementOrderActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PlacementOrderActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.Infrastructure.Models.OrderMin MyNewOrder {
                get {
                    return ((Dataifx.Trading.Infrastructure.Models.OrderMin)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario usuarioWeb {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.resultado = ((bool)(this.GetVariableValue((2 + locationsOffset))));
                this.IdFirma = ((int)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((2 + locationsOffset), this.resultado);
                this.SetVariableValue((3 + locationsOffset), this.IdFirma);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 0)].Name != "MyNewOrder") 
                            || (locationReferences[(offset + 0)].Type != typeof(Dataifx.Trading.Infrastructure.Models.OrderMin)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "usuarioWeb") 
                            || (locationReferences[(offset + 1)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "resultado") 
                            || (locationReferences[(offset + 2)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "IdFirma") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return PlacementOrderActivity_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PlacementOrderActivity_TypedDataContext1_ForReadOnly : PlacementOrderActivity_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool resultado;
            
            protected int IdFirma;
            
            public PlacementOrderActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PlacementOrderActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PlacementOrderActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.Infrastructure.Models.OrderMin MyNewOrder {
                get {
                    return ((Dataifx.Trading.Infrastructure.Models.OrderMin)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario usuarioWeb {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.resultado = ((bool)(this.GetVariableValue((2 + locationsOffset))));
                this.IdFirma = ((int)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 0)].Name != "MyNewOrder") 
                            || (locationReferences[(offset + 0)].Type != typeof(Dataifx.Trading.Infrastructure.Models.OrderMin)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "usuarioWeb") 
                            || (locationReferences[(offset + 1)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "resultado") 
                            || (locationReferences[(offset + 2)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "IdFirma") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return PlacementOrderActivity_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PlacementOrderActivity_TypedDataContext2 : PlacementOrderActivity_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool ClienteValido;
            
            protected bool MontoMaximoValido;
            
            public PlacementOrderActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PlacementOrderActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PlacementOrderActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.CommonObjects.Orden MyOrder {
                get {
                    return ((Dataifx.Trading.CommonObjects.Orden)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario usuarioAux {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 72 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                usuarioWeb;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr2Get() {
                
                #line 72 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                usuarioWeb;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                
                #line 72 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                usuarioWeb = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 86 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    usuarioWeb.Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr4Get() {
                
                #line 86 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                    usuarioWeb.Id;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(string value) {
                
                #line 86 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                    usuarioWeb.Id = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 100 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.PerfilUsuario>> expression = () => 
                        usuarioWeb.Perfil;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.PerfilUsuario @__Expr6Get() {
                
                #line 100 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                        usuarioWeb.Perfil;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.PerfilUsuario ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(Dataifx.Trading.CommonObjects.PerfilUsuario value) {
                
                #line 100 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                        usuarioWeb.Perfil = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(Dataifx.Trading.CommonObjects.PerfilUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 114 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.Orden>> expression = () => 
                            MyOrder;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.Orden @__Expr8Get() {
                
                #line 114 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                            MyOrder;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.Orden ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(Dataifx.Trading.CommonObjects.Orden value) {
                
                #line 114 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                            MyOrder = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(Dataifx.Trading.CommonObjects.Orden value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 730 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Error>> expression = () => 
                                      MyNewOrder.ErrorService;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Error @__Expr11Get() {
                
                #line 730 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                      MyNewOrder.ErrorService;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Error ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(Dataifx.Trading.Infrastructure.Models.Error value) {
                
                #line 730 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                      MyNewOrder.ErrorService = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(Dataifx.Trading.Infrastructure.Models.Error value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 742 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      MyNewOrder.ErrorService.Code;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr12Get() {
                
                #line 742 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                      MyNewOrder.ErrorService.Code;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(int value) {
                
                #line 742 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                      MyNewOrder.ErrorService.Code = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 752 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      MyNewOrder.ErrorService.Description;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr13Get() {
                
                #line 752 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                      MyNewOrder.ErrorService.Description;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(string value) {
                
                #line 752 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                      MyNewOrder.ErrorService.Description = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 762 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      MyNewOrder.ErrorService.existError;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr14Get() {
                
                #line 762 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                      MyNewOrder.ErrorService.existError;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(bool value) {
                
                #line 762 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                      MyNewOrder.ErrorService.existError = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 137 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                                      usuarioAux;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr17Get() {
                
                #line 137 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                      usuarioAux;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                
                #line 137 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                      usuarioAux = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 591 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              ClienteValido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr20Get() {
                
                #line 591 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                              ClienteValido;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr20Set(bool value) {
                
                #line 591 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                              ClienteValido = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr20Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr20Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 481 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Error>> expression = () => 
                                                            MyNewOrder.ErrorService;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Error @__Expr23Get() {
                
                #line 481 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                            MyNewOrder.ErrorService;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Error ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr23Set(Dataifx.Trading.Infrastructure.Models.Error value) {
                
                #line 481 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                            MyNewOrder.ErrorService = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr23Set(Dataifx.Trading.Infrastructure.Models.Error value) {
                this.GetValueTypeValues();
                this.@__Expr23Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 542 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                    MyNewOrder.ErrorService.Code;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr25Get() {
                
                #line 542 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                    MyNewOrder.ErrorService.Code;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr25Set(int value) {
                
                #line 542 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                    MyNewOrder.ErrorService.Code = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr25Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr25Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 554 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                        MyNewOrder.ErrorService.Description;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr26Get() {
                
                #line 554 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                        MyNewOrder.ErrorService.Description;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(string value) {
                
                #line 554 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                        MyNewOrder.ErrorService.Description = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 524 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                            MyNewOrder.ErrorService.existError;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr27Get() {
                
                #line 524 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                            MyNewOrder.ErrorService.existError;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(bool value) {
                
                #line 524 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                            MyNewOrder.ErrorService.existError = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 500 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                    MyNewOrder.ErrorService.Code;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr28Get() {
                
                #line 500 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                    MyNewOrder.ErrorService.Code;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(int value) {
                
                #line 500 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                    MyNewOrder.ErrorService.Code = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 512 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                        MyNewOrder.ErrorService.Description;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr29Get() {
                
                #line 512 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                        MyNewOrder.ErrorService.Description;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(string value) {
                
                #line 512 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                        MyNewOrder.ErrorService.Description = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 180 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                          usuarioWeb.InfoCliente.NumeroDocumento;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr32Get() {
                
                #line 180 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                          usuarioWeb.InfoCliente.NumeroDocumento;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr32Set(string value) {
                
                #line 180 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                          usuarioWeb.InfoCliente.NumeroDocumento = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr32Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr32Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 192 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.TipoDocumento>> expression = () => 
                                                          usuarioWeb.InfoCliente.TipoDoc;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.TipoDocumento @__Expr34Get() {
                
                #line 192 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                          usuarioWeb.InfoCliente.TipoDoc;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.TipoDocumento ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr34Set(Dataifx.Trading.CommonObjects.TipoDocumento value) {
                
                #line 192 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                          usuarioWeb.InfoCliente.TipoDoc = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr34Set(Dataifx.Trading.CommonObjects.TipoDocumento value) {
                this.GetValueTypeValues();
                this.@__Expr34Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 204 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                          usuarioWeb.UsuarioSoporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr36Get() {
                
                #line 204 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                          usuarioWeb.UsuarioSoporte;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr36Set(string value) {
                
                #line 204 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                          usuarioWeb.UsuarioSoporte = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr36Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr36Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 410 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                resultado;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr39Get() {
                
                #line 410 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                resultado;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr39Set(bool value) {
                
                #line 410 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                resultado = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr39Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr39Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 341 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Error>> expression = () => 
                                                                            MyNewOrder.ErrorService;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Error @__Expr42Get() {
                
                #line 341 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                            MyNewOrder.ErrorService;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Error ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(Dataifx.Trading.Infrastructure.Models.Error value) {
                
                #line 341 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                            MyNewOrder.ErrorService = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(Dataifx.Trading.Infrastructure.Models.Error value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 353 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                            MyNewOrder.ErrorService.Code;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr43Get() {
                
                #line 353 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                            MyNewOrder.ErrorService.Code;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr43Set(int value) {
                
                #line 353 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                            MyNewOrder.ErrorService.Code = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr43Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr43Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 363 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            MyNewOrder.ErrorService.Description;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr44Get() {
                
                #line 363 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                            MyNewOrder.ErrorService.Description;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr44Set(string value) {
                
                #line 363 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                            MyNewOrder.ErrorService.Description = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr44Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr44Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 373 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                            MyNewOrder.ErrorService.existError;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr45Get() {
                
                #line 373 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                            MyNewOrder.ErrorService.existError;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr45Set(bool value) {
                
                #line 373 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                            MyNewOrder.ErrorService.existError = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr45Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr45Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 266 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                              MyNewOrder.Username;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr48Get() {
                
                #line 266 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                              MyNewOrder.Username;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr48Set(string value) {
                
                #line 266 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                              MyNewOrder.Username = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr48Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr48Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 280 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                  MyNewOrder.Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr50Get() {
                
                #line 280 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                                  MyNewOrder.Id;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr50Set(int value) {
                
                #line 280 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                                  MyNewOrder.Id = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr50Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr50Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 295 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.StateOrder>> expression = () => 
                                                                                        MyNewOrder.StateOrder;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.StateOrder @__Expr52Get() {
                
                #line 295 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                                        MyNewOrder.StateOrder;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.StateOrder ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr52Set(Dataifx.Trading.Infrastructure.Models.StateOrder value) {
                
                #line 295 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                                        MyNewOrder.StateOrder = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr52Set(Dataifx.Trading.Infrastructure.Models.StateOrder value) {
                this.GetValueTypeValues();
                this.@__Expr52Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 307 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Error>> expression = () => 
                                                                                        MyNewOrder.ErrorService;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Error @__Expr54Get() {
                
                #line 307 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                                        MyNewOrder.ErrorService;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Error ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr54Set(Dataifx.Trading.Infrastructure.Models.Error value) {
                
                #line 307 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                                        MyNewOrder.ErrorService = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr54Set(Dataifx.Trading.Infrastructure.Models.Error value) {
                this.GetValueTypeValues();
                this.@__Expr54Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 319 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                        MyNewOrder.ErrorService.existError;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr55Get() {
                
                #line 319 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                                        MyNewOrder.ErrorService.existError;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr55Set(bool value) {
                
                #line 319 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                                        MyNewOrder.ErrorService.existError = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr55Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr55Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 390 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                  resultado;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr59Get() {
                
                #line 390 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                  resultado;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr59Set(bool value) {
                
                #line 390 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                  resultado = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr59Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr59Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 228 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                  resultado;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr61Get() {
                
                #line 228 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                  resultado;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr61Set(bool value) {
                
                #line 228 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                                  resultado = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr61Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr61Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 455 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                            resultado;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr64Get() {
                
                #line 455 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                            resultado;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr64Set(bool value) {
                
                #line 455 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                            resultado = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr64Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr64Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 436 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                            resultado;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr66Get() {
                
                #line 436 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                            resultado;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr66Set(bool value) {
                
                #line 436 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                            resultado = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr66Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr66Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 156 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              ClienteValido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr68Get() {
                
                #line 156 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                              ClienteValido;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr68Set(bool value) {
                
                #line 156 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                              ClienteValido = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr68Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr68Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 613 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      MontoMaximoValido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr69Get() {
                
                #line 613 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                      MontoMaximoValido;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr69Set(bool value) {
                
                #line 613 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                      MontoMaximoValido = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr69Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr69Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 704 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              ClienteValido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr72Get() {
                
                #line 704 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                              ClienteValido;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr72Set(bool value) {
                
                #line 704 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                              ClienteValido = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr72Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr72Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 630 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              ClienteValido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr74Get() {
                
                #line 630 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                              ClienteValido;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr74Set(bool value) {
                
                #line 630 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                              ClienteValido = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr74Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr74Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 653 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Error>> expression = () => 
                                                        MyNewOrder.ErrorService;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Error @__Expr77Get() {
                
                #line 653 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                        MyNewOrder.ErrorService;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Error ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr77Set(Dataifx.Trading.Infrastructure.Models.Error value) {
                
                #line 653 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                        MyNewOrder.ErrorService = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr77Set(Dataifx.Trading.Infrastructure.Models.Error value) {
                this.GetValueTypeValues();
                this.@__Expr77Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 665 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        MyNewOrder.ErrorService.Code;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr78Get() {
                
                #line 665 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                        MyNewOrder.ErrorService.Code;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr78Set(int value) {
                
                #line 665 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                        MyNewOrder.ErrorService.Code = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr78Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr78Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 675 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                        MyNewOrder.ErrorService.existError;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr79Get() {
                
                #line 675 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                        MyNewOrder.ErrorService.existError;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr79Get() {
                this.GetValueTypeValues();
                return this.@__Expr79Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr79Set(bool value) {
                
                #line 675 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                        MyNewOrder.ErrorService.existError = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr79Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr79Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 685 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                        MyNewOrder.ErrorService.Description;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr80Get() {
                
                #line 685 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                        MyNewOrder.ErrorService.Description;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr80Set(string value) {
                
                #line 685 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                                                        MyNewOrder.ErrorService.Description = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr80Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr80Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 785 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                usuarioWeb;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr82Get() {
                
                #line 785 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                usuarioWeb;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr82Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                
                #line 785 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                usuarioWeb = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr82Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr82Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr84GetTree() {
                
                #line 799 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                    usuarioWeb;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr84Get() {
                
                #line 799 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                    usuarioWeb;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr84Get() {
                this.GetValueTypeValues();
                return this.@__Expr84Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr84Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                
                #line 799 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                
                    usuarioWeb = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr84Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr84Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.ClienteValido = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                this.MontoMaximoValido = ((bool)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.ClienteValido);
                this.SetVariableValue((5 + locationsOffset), this.MontoMaximoValido);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 6)].Name != "MyOrder") 
                            || (locationReferences[(offset + 6)].Type != typeof(Dataifx.Trading.CommonObjects.Orden)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "usuarioAux") 
                            || (locationReferences[(offset + 7)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "ClienteValido") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "MontoMaximoValido") 
                            || (locationReferences[(offset + 5)].Type != typeof(bool)))) {
                    return false;
                }
                return PlacementOrderActivity_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PlacementOrderActivity_TypedDataContext2_ForReadOnly : PlacementOrderActivity_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool ClienteValido;
            
            protected bool MontoMaximoValido;
            
            public PlacementOrderActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PlacementOrderActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PlacementOrderActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.CommonObjects.Orden MyOrder {
                get {
                    return ((Dataifx.Trading.CommonObjects.Orden)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario usuarioAux {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 66 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
          IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr0Get() {
                
                #line 66 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
          IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 77 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                new InfoUsuario() { InfoCliente = new InfoCliente { Id = MyNewOrder.Client.Id } };
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr1Get() {
                
                #line 77 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                new InfoUsuario() { InfoCliente = new InfoCliente { Id = MyNewOrder.Client.Id } };
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 91 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    MyNewOrder.Client.OriginatorId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 91 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                    MyNewOrder.Client.OriginatorId;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 105 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.PerfilUsuario>> expression = () => 
                        Dataifx.Trading.Business.Converter.ConvertProfile.ObtenerPerfil(MyNewOrder.OriginatorOrder.Profile);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.PerfilUsuario @__Expr5Get() {
                
                #line 105 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                        Dataifx.Trading.Business.Converter.ConvertProfile.ObtenerPerfil(MyNewOrder.OriginatorOrder.Profile);
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.PerfilUsuario ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 119 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.Orden>> expression = () => 
                            Business.Orden.FillOrder(MyNewOrder, usuarioWeb);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.Orden @__Expr7Get() {
                
                #line 119 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                            Business.Orden.FillOrder(MyNewOrder, usuarioWeb);
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.Orden ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 126 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            usuarioWeb != null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr9Get() {
                
                #line 126 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                            usuarioWeb != null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 735 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Error>> expression = () => 
                                      new Error();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Error @__Expr10Get() {
                
                #line 735 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                      new Error();
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Error ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 131 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr15Get() {
                
                #line 131 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 142 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                                      Business.Usuario.ObtenerDatosCuentaporWinsiob(usuarioWeb.InfoCliente.Id);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr16Get() {
                
                #line 142 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                      Business.Usuario.ObtenerDatosCuentaporWinsiob(usuarioWeb.InfoCliente.Id);
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 149 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      usuarioWeb.Perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr18Get() {
                
                #line 149 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                      usuarioWeb.Perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 596 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              Business.Orden.ValidarDatosCliente(MyOrder,usuarioWeb,MontoMaximoValido,usuarioAux);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr19Get() {
                
                #line 596 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                              Business.Orden.ValidarDatosCliente(MyOrder,usuarioWeb,MontoMaximoValido,usuarioAux);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 168 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              ClienteValido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr21Get() {
                
                #line 168 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                              ClienteValido;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 486 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Error>> expression = () => 
                                                            new Infrastructure.Models.Error();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Error @__Expr22Get() {
                
                #line 486 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                            new Infrastructure.Models.Error();
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Error ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 493 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                            !MontoMaximoValido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr24Get() {
                
                #line 493 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                            !MontoMaximoValido;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 173 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                  IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr30Get() {
                
                #line 173 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                  IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 185 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                          usuarioAux.InfoCliente.NumeroDocumento;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr31Get() {
                
                #line 185 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                          usuarioAux.InfoCliente.NumeroDocumento;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 197 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.TipoDocumento>> expression = () => 
                                                          usuarioAux.InfoCliente.TipoDoc;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.TipoDocumento @__Expr33Get() {
                
                #line 197 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                          usuarioAux.InfoCliente.TipoDoc;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.TipoDocumento ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 209 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                          usuarioAux.UsuarioSoporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr35Get() {
                
                #line 209 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                          usuarioAux.UsuarioSoporte;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 217 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                        usuarioWeb.Perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr37Get() {
                
                #line 217 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                        usuarioWeb.Perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 415 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                Business.Orden.Cursar(MyOrder, usuarioWeb , MyNewOrder.Client.ClientIp);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr38Get() {
                
                #line 415 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                Business.Orden.Cursar(MyOrder, usuarioWeb , MyNewOrder.Client.ClientIp);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 240 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                  resultado;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr40Get() {
                
                #line 240 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                  resultado;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 346 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Error>> expression = () => 
                                                                            new Infrastructure.Models.Error();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Error @__Expr41Get() {
                
                #line 346 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                            new Infrastructure.Models.Error();
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Error ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 245 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      MyOrder == null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr46Get() {
                
                #line 245 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                      MyOrder == null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 271 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                              MyNewOrder.Client.Name;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr47Get() {
                
                #line 271 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                              MyNewOrder.Client.Name;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 285 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                  Convert.ToInt32(MyOrder.Id);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr49Get() {
                
                #line 285 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                                  Convert.ToInt32(MyOrder.Id);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 300 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.StateOrder>> expression = () => 
                                                                                        StateOrder.Sent;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.StateOrder @__Expr51Get() {
                
                #line 300 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                                        StateOrder.Sent;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.StateOrder ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 312 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Error>> expression = () => 
                                                                                        new Infrastructure.Models.Error();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Error @__Expr53Get() {
                
                #line 312 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                                        new Infrastructure.Models.Error();
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Error ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 251 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                                            DateTime.Now;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr56Get() {
                
                #line 251 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                            DateTime.Now;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 222 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                            IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr57Get() {
                
                #line 222 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                            IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 395 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                  Business.Orden.CursarComercialCiti(MyOrder, usuarioWeb, MyNewOrder.Client.ClientIp);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr58Get() {
                
                #line 395 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                  Business.Orden.CursarComercialCiti(MyOrder, usuarioWeb, MyNewOrder.Client.ClientIp);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 233 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                  Business.Orden.CursarComercial(MyOrder,usuarioWeb,MyNewOrder.Client.ClientIp);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr60Get() {
                
                #line 233 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                                  Business.Orden.CursarComercial(MyOrder,usuarioWeb,MyNewOrder.Client.ClientIp);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 429 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                    usuarioWeb.Perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr62Get() {
                
                #line 429 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                    usuarioWeb.Perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 460 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                            Business.Correval.OrderRouting.Cursar(MyOrder, usuarioWeb, MyNewOrder.Client.ClientIp, '1');
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr63Get() {
                
                #line 460 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                            Business.Correval.OrderRouting.Cursar(MyOrder, usuarioWeb, MyNewOrder.Client.ClientIp, '1');
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 441 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                            Business.Correval.OrderRouting.CursarComercial(MyOrder, usuarioWeb, MyNewOrder.Client.ClientIp, '1');
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr65Get() {
                
                #line 441 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                            Business.Correval.OrderRouting.CursarComercial(MyOrder, usuarioWeb, MyNewOrder.Client.ClientIp, '1');
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 161 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              Business.Orden.ValidarDatosClienteComercial(MyOrder,usuarioWeb,MontoMaximoValido,usuarioAux);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr67Get() {
                
                #line 161 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                              Business.Orden.ValidarDatosClienteComercial(MyOrder,usuarioWeb,MontoMaximoValido,usuarioAux);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 623 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      MyNewOrder.Instrument.Type == Infrastructure.Enumerations.MarketType.Futures || MyNewOrder.Instrument.Type == Infrastructure.Enumerations.MarketType.Energy;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr70Get() {
                
                #line 623 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                      MyNewOrder.Instrument.Type == Infrastructure.Enumerations.MarketType.Futures || MyNewOrder.Instrument.Type == Infrastructure.Enumerations.MarketType.Energy;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 709 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              Business.Correval.OrderRouting.ValidarDatosCliente(MyOrder,usuarioWeb,MyOrder.InfoCliente.Id.Replace(',','.'), Business.Correval.User.ObtenerDatosCuenta(usuarioWeb.Id), MyNewOrder.Client);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr71Get() {
                
                #line 709 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                              Business.Correval.OrderRouting.ValidarDatosCliente(MyOrder,usuarioWeb,MyOrder.InfoCliente.Id.Replace(',','.'), Business.Correval.User.ObtenerDatosCuenta(usuarioWeb.Id), MyNewOrder.Client);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 635 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              Business.Correval.OrderRouting.ValidarGarantias(MyNewOrder, usuarioWeb, Business.Correval.User.ObtenerDatosCuenta(usuarioWeb.Id));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr73Get() {
                
                #line 635 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                              Business.Correval.OrderRouting.ValidarGarantias(MyNewOrder, usuarioWeb, Business.Correval.User.ObtenerDatosCuenta(usuarioWeb.Id));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 642 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              ClienteValido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr75Get() {
                
                #line 642 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                              ClienteValido;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 658 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Error>> expression = () => 
                                                        new Infrastructure.Models.Error();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Error @__Expr76Get() {
                
                #line 658 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                                                        new Infrastructure.Models.Error();
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Error ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 790 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                new InfoUsuario();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr81Get() {
                
                #line 790 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                new InfoUsuario();
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 804 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                    Business.Correval.User.ObtenerInformacionPorCliente(MyNewOrder.Client.Id);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr83Get() {
                
                #line 804 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PLACEMENTORDERACTIVITY.XAML"
                return 
                    Business.Correval.User.ObtenerInformacionPorCliente(MyNewOrder.Client.Id);
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
            }
            
            protected override void GetValueTypeValues() {
                this.ClienteValido = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                this.MontoMaximoValido = ((bool)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 6)].Name != "MyOrder") 
                            || (locationReferences[(offset + 6)].Type != typeof(Dataifx.Trading.CommonObjects.Orden)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "usuarioAux") 
                            || (locationReferences[(offset + 7)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "ClienteValido") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "MontoMaximoValido") 
                            || (locationReferences[(offset + 5)].Type != typeof(bool)))) {
                    return false;
                }
                return PlacementOrderActivity_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
