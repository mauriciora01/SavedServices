namespace Dataifx.Trading.Activity {
    
    #line 28 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OriginatorActivity.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OriginatorActivity.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 29 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OriginatorActivity.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OriginatorActivity.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OriginatorActivity.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OriginatorActivity.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 30 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OriginatorActivity.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 31 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OriginatorActivity.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 32 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OriginatorActivity.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 33 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OriginatorActivity.xaml"
    using Dataifx.Trading.CommonObjects;
    
    #line default
    #line hidden
    
    #line 34 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OriginatorActivity.xaml"
    using Dataifx.Trading.Infrastructure.Models;
    
    #line default
    #line hidden
    
    #line 35 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OriginatorActivity.xaml"
    using Dataifx.Trading.Infrastructure.Enumerations;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OriginatorActivity.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class OriginatorActivity : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = OriginatorActivity_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext0 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext1 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext2 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext3 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext3.GetLocation<System.Data.DataTable>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext4 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext5 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext6 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext6.GetLocation<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext7 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext8 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext8.GetLocation<int>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext9 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext10 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext10.GetLocation<System.DateTime>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext11 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext12 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext12.GetLocation<System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client>>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext13 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext14 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext14.GetLocation<bool>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext15 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext16 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext16.GetLocation<string>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext17 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext18 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext18.GetLocation<Dataifx.Trading.Infrastructure.Enumerations.PerfilUsuario>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext19 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext20 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext20.GetLocation<string>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext21 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext22 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext22.GetLocation<string>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext23 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext24 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext24.GetLocation<int>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext25 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext26 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext26.GetLocation<string>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext27 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext27.GetLocation<int>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext28 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext28.GetLocation<bool>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext29 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext30 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext30.GetLocation<string>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext31 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext32 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext32.GetLocation<System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext33 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext34 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext34.GetLocation<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext35 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext36 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext36.GetLocation<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext37 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext38 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext38.GetLocation<int>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext39 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext40 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext40.GetLocation<System.DateTime>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext41 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext42 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext42.GetLocation<System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client>>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext43 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext44 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext45 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext45.GetLocation<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext46 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext47 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext47.GetLocation<int>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext48 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext49 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext49.GetLocation<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext50 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext51 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext51.GetLocation<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext52 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext53 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext53.GetLocation<int>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext54 = ((OriginatorActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OriginatorActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OriginatorActivity_TypedDataContext2(locations, activityContext, true);
                }
                OriginatorActivity_TypedDataContext2 refDataContext55 = ((OriginatorActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext55.GetLocation<System.Data.DataTable>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set, expressionId, this.rootActivity, activityContext);
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
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext0 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext1 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext2 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                OriginatorActivity_TypedDataContext2 refDataContext3 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext3.GetLocation<System.Data.DataTable>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext4 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext5 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                OriginatorActivity_TypedDataContext2 refDataContext6 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext6.GetLocation<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext7 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                OriginatorActivity_TypedDataContext2 refDataContext8 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext8.GetLocation<int>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext9 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                OriginatorActivity_TypedDataContext2 refDataContext10 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext10.GetLocation<System.DateTime>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext11 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                OriginatorActivity_TypedDataContext2 refDataContext12 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext12.GetLocation<System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client>>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext13 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                OriginatorActivity_TypedDataContext2 refDataContext14 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext14.GetLocation<bool>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext15 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                OriginatorActivity_TypedDataContext2 refDataContext16 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext16.GetLocation<string>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext17 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                OriginatorActivity_TypedDataContext2 refDataContext18 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext18.GetLocation<Dataifx.Trading.Infrastructure.Enumerations.PerfilUsuario>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext19 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                OriginatorActivity_TypedDataContext2 refDataContext20 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext20.GetLocation<string>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set);
            }
            if ((expressionId == 21)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext21 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                OriginatorActivity_TypedDataContext2 refDataContext22 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext22.GetLocation<string>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set);
            }
            if ((expressionId == 23)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext23 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                OriginatorActivity_TypedDataContext2 refDataContext24 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext24.GetLocation<int>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext25 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                OriginatorActivity_TypedDataContext2 refDataContext26 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext26.GetLocation<string>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                OriginatorActivity_TypedDataContext2 refDataContext27 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext27.GetLocation<int>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                OriginatorActivity_TypedDataContext2 refDataContext28 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext28.GetLocation<bool>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set);
            }
            if ((expressionId == 29)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext29 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                OriginatorActivity_TypedDataContext2 refDataContext30 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext30.GetLocation<string>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set);
            }
            if ((expressionId == 31)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext31 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                OriginatorActivity_TypedDataContext2 refDataContext32 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext32.GetLocation<System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
            }
            if ((expressionId == 33)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext33 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                OriginatorActivity_TypedDataContext2 refDataContext34 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext34.GetLocation<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set);
            }
            if ((expressionId == 35)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext35 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                OriginatorActivity_TypedDataContext2 refDataContext36 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext36.GetLocation<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set);
            }
            if ((expressionId == 37)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext37 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                OriginatorActivity_TypedDataContext2 refDataContext38 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext38.GetLocation<int>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set);
            }
            if ((expressionId == 39)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext39 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                OriginatorActivity_TypedDataContext2 refDataContext40 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext40.GetLocation<System.DateTime>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set);
            }
            if ((expressionId == 41)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext41 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                OriginatorActivity_TypedDataContext2 refDataContext42 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext42.GetLocation<System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client>>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext43 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext44 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                OriginatorActivity_TypedDataContext2 refDataContext45 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext45.GetLocation<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set);
            }
            if ((expressionId == 46)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext46 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                OriginatorActivity_TypedDataContext2 refDataContext47 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext47.GetLocation<int>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set);
            }
            if ((expressionId == 48)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext48 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                OriginatorActivity_TypedDataContext2 refDataContext49 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext49.GetLocation<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set);
            }
            if ((expressionId == 50)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext50 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                OriginatorActivity_TypedDataContext2 refDataContext51 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext51.GetLocation<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set);
            }
            if ((expressionId == 52)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext52 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                OriginatorActivity_TypedDataContext2 refDataContext53 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext53.GetLocation<int>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set);
            }
            if ((expressionId == 54)) {
                OriginatorActivity_TypedDataContext2_ForReadOnly valDataContext54 = new OriginatorActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                OriginatorActivity_TypedDataContext2 refDataContext55 = new OriginatorActivity_TypedDataContext2(locations, true);
                return refDataContext55.GetLocation<System.Data.DataTable>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "new List<Infrastructure.Enumerations.MarketType>()") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iu.Perfil") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.ObtenerCuentasOrdenantes(iu, strIdUser, \"\", \"\")") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtClientes") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.FillClientUser(dtClientes)") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Clients") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.PuntasProfundidad.ObtenerNumPuntasAMostrar(iu, strIdUser)") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.NumPyP") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.ObtenerUltimoIngreso(strIdUser, strIpAddress)") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.lastdateadmission") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Clients") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.Account") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iu.IsCertified") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.IsCertified") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iu.Id") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.Id") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Dataifx.Trading.Business.Converter.ConvertProfile.ObtenerPerfil(iu.Perfil)") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.Profile") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iu.InfoClave.ClaveInicial.ToString()") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.initialPswd") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iu.UsuarioSoporte") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.idTrader") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iu.InfoClave.DiasRestantesExpiracionClave") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.KeyExpiresDays") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iu.Nombre + \" \" + iu.Apellidos") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.Name") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.Error.Code") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.Error.existError") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Empty") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.Error.Description") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ListMarket.ToList()") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.ListMarket") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.GetAccountClientes(strIdUser)") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Clients") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(List<Infrastructure.Enumerations.MarketType>)Business.Correval.User.ConsultarTip" +
                            "oMercado(strIdUser)") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ListMarket") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.BidsOffers.ObtenerNumPuntasAMostrar(iu, Convert.ToDecimal(iu.In" +
                            "foCliente.Id))") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.NumPyP") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.ObtenerUltimoIngreso(strIdUser, strIpAddress)") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.lastdateadmission") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Clients") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.Account") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.GetAccountClientsByTrader(iu.InfoCliente.Id)") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Clients") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.PuntasProfundidad.ObtenerNumPuntasAMostrarOtros(iu,iu.Id)") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.NumPyP") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.GetAccountClientesByTrader(iu.InfoCliente.Id)") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Clients") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.ConsultarTipoMercadoComercial(iu.InfoCliente.Id)") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ListMarket") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.BidsOffers.ObtenerNumPuntasAMostrarOtros(iu, iu.Id)") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "initialUser.NumPyP") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.ObtenerCuentasOrdenantesIns(iu, strIdUser, \"\", \"\")") 
                        && (OriginatorActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtClientes") 
                        && (OriginatorActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
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
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new OriginatorActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new OriginatorActivity_TypedDataContext2(locationReferences).@__Expr55GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OriginatorActivity_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public OriginatorActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OriginatorActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OriginatorActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class OriginatorActivity_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public OriginatorActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OriginatorActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OriginatorActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class OriginatorActivity_TypedDataContext1 : OriginatorActivity_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int IdFirma;
            
            public OriginatorActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OriginatorActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OriginatorActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.Infrastructure.Models.Originator initialUser {
                get {
                    return ((Dataifx.Trading.Infrastructure.Models.Originator)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected string strIpAddress {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected string strIdUser {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario iu {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
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
                this.IdFirma = ((int)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((3 + locationsOffset), this.IdFirma);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 0)].Name != "initialUser") 
                            || (locationReferences[(offset + 0)].Type != typeof(Dataifx.Trading.Infrastructure.Models.Originator)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "strIpAddress") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "strIdUser") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "iu") 
                            || (locationReferences[(offset + 4)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "IdFirma") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return OriginatorActivity_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OriginatorActivity_TypedDataContext1_ForReadOnly : OriginatorActivity_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int IdFirma;
            
            public OriginatorActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OriginatorActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OriginatorActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.Infrastructure.Models.Originator initialUser {
                get {
                    return ((Dataifx.Trading.Infrastructure.Models.Originator)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected string strIpAddress {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected string strIdUser {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario iu {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((4 + locationsOffset))));
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
                this.IdFirma = ((int)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 0)].Name != "initialUser") 
                            || (locationReferences[(offset + 0)].Type != typeof(Dataifx.Trading.Infrastructure.Models.Originator)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "strIpAddress") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "strIdUser") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "iu") 
                            || (locationReferences[(offset + 4)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "IdFirma") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return OriginatorActivity_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OriginatorActivity_TypedDataContext2 : OriginatorActivity_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public OriginatorActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OriginatorActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OriginatorActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Data.DataTable dtClientes {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> Clients {
                get {
                    return ((System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> ListMarket {
                get {
                    return ((System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType>)(this.GetVariableValue((7 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 76 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                  dtClientes;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr3Get() {
                
                #line 76 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                  dtClientes;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(System.Data.DataTable value) {
                
                #line 76 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                  dtClientes = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 94 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>> expression = () => 
                        Clients;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> @__Expr6Get() {
                
                #line 94 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                        Clients;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> value) {
                
                #line 94 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                        Clients = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 108 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            initialUser.NumPyP;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr8Get() {
                
                #line 108 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                            initialUser.NumPyP;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(int value) {
                
                #line 108 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                            initialUser.NumPyP = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 123 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                  initialUser.lastdateadmission;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr10Get() {
                
                #line 123 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                  initialUser.lastdateadmission;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(System.DateTime value) {
                
                #line 123 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                  initialUser.lastdateadmission = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 135 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client>>> expression = () => 
                                  initialUser.Account;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client> @__Expr12Get() {
                
                #line 135 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                  initialUser.Account;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client> ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client> value) {
                
                #line 135 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                  initialUser.Account = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client> value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 147 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  initialUser.IsCertified;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr14Get() {
                
                #line 147 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                  initialUser.IsCertified;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(bool value) {
                
                #line 147 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                  initialUser.IsCertified = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 163 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      initialUser.Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr16Get() {
                
                #line 163 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                      initialUser.Id;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(string value) {
                
                #line 163 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                      initialUser.Id = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 175 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Enumerations.PerfilUsuario>> expression = () => 
                                      initialUser.Profile;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Enumerations.PerfilUsuario @__Expr18Get() {
                
                #line 175 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                      initialUser.Profile;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Enumerations.PerfilUsuario ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(Dataifx.Trading.Infrastructure.Enumerations.PerfilUsuario value) {
                
                #line 175 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                      initialUser.Profile = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(Dataifx.Trading.Infrastructure.Enumerations.PerfilUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 187 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      initialUser.initialPswd;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr20Get() {
                
                #line 187 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                      initialUser.initialPswd;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr20Set(string value) {
                
                #line 187 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                      initialUser.initialPswd = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr20Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr20Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 199 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      initialUser.idTrader;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr22Get() {
                
                #line 199 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                      initialUser.idTrader;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr22Set(string value) {
                
                #line 199 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                      initialUser.idTrader = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr22Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr22Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 215 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                          initialUser.KeyExpiresDays;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr24Get() {
                
                #line 215 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                          initialUser.KeyExpiresDays;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr24Set(int value) {
                
                #line 215 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                          initialUser.KeyExpiresDays = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 227 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          initialUser.Name;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr26Get() {
                
                #line 227 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                          initialUser.Name;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(string value) {
                
                #line 227 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                          initialUser.Name = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 239 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                          initialUser.Error.Code;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr27Get() {
                
                #line 239 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                          initialUser.Error.Code;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(int value) {
                
                #line 239 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                          initialUser.Error.Code = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 249 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          initialUser.Error.existError;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr28Get() {
                
                #line 249 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                          initialUser.Error.existError;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(bool value) {
                
                #line 249 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                          initialUser.Error.existError = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 259 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          initialUser.Error.Description;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr30Get() {
                
                #line 259 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                          initialUser.Error.Description;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr30Set(string value) {
                
                #line 259 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                          initialUser.Error.Description = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr30Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr30Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 274 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>> expression = () => 
                                            initialUser.ListMarket;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Enumerations.MarketType> @__Expr32Get() {
                
                #line 274 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                            initialUser.ListMarket;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Enumerations.MarketType> ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr32Set(System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Enumerations.MarketType> value) {
                
                #line 274 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                            initialUser.ListMarket = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr32Set(System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Enumerations.MarketType> value) {
                this.GetValueTypeValues();
                this.@__Expr32Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 298 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>> expression = () => 
                        Clients;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> @__Expr34Get() {
                
                #line 298 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                        Clients;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr34Set(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> value) {
                
                #line 298 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                        Clients = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr34Set(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> value) {
                this.GetValueTypeValues();
                this.@__Expr34Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 312 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>> expression = () => 
                            ListMarket;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> @__Expr36Get() {
                
                #line 312 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                            ListMarket;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr36Set(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> value) {
                
                #line 312 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                            ListMarket = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr36Set(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> value) {
                this.GetValueTypeValues();
                this.@__Expr36Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 326 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                initialUser.NumPyP;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr38Get() {
                
                #line 326 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                initialUser.NumPyP;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr38Set(int value) {
                
                #line 326 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                initialUser.NumPyP = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr38Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr38Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 341 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                      initialUser.lastdateadmission;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr40Get() {
                
                #line 341 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                      initialUser.lastdateadmission;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr40Set(System.DateTime value) {
                
                #line 341 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                      initialUser.lastdateadmission = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr40Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr40Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 353 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client>>> expression = () => 
                                      initialUser.Account;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client> @__Expr42Get() {
                
                #line 353 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                      initialUser.Account;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client> ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client> value) {
                
                #line 353 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                                      initialUser.Account = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client> value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 456 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>> expression = () => 
                  Clients;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> @__Expr45Get() {
                
                #line 456 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                  Clients;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr45Set(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> value) {
                
                #line 456 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                  Clients = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr45Set(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> value) {
                this.GetValueTypeValues();
                this.@__Expr45Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 470 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      initialUser.NumPyP;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr47Get() {
                
                #line 470 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                      initialUser.NumPyP;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr47Set(int value) {
                
                #line 470 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                      initialUser.NumPyP = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr47Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr47Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 407 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>> expression = () => 
                  Clients;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> @__Expr49Get() {
                
                #line 407 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                  Clients;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr49Set(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> value) {
                
                #line 407 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                  Clients = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr49Set(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> value) {
                this.GetValueTypeValues();
                this.@__Expr49Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 421 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>> expression = () => 
                      ListMarket;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> @__Expr51Get() {
                
                #line 421 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                      ListMarket;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr51Set(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> value) {
                
                #line 421 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                      ListMarket = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr51Set(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> value) {
                this.GetValueTypeValues();
                this.@__Expr51Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 435 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                          initialUser.NumPyP;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr53Get() {
                
                #line 435 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                          initialUser.NumPyP;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr53Set(int value) {
                
                #line 435 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                          initialUser.NumPyP = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr53Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr53Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 386 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                dtClientes;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr55Get() {
                
                #line 386 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                dtClientes;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr55Set(System.Data.DataTable value) {
                
                #line 386 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                
                dtClientes = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr55Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr55Set(value);
                this.SetValueTypeValues();
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
                if (((locationReferences[(offset + 5)].Name != "dtClientes") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Clients") 
                            || (locationReferences[(offset + 6)].Type != typeof(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "ListMarket") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType>)))) {
                    return false;
                }
                return OriginatorActivity_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OriginatorActivity_TypedDataContext2_ForReadOnly : OriginatorActivity_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public OriginatorActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OriginatorActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OriginatorActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Data.DataTable dtClientes {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> Clients {
                get {
                    return ((System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> ListMarket {
                get {
                    return ((System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType>)(this.GetVariableValue((7 + locationsOffset))));
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
                
                #line 65 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>> expression = () => 
          new List<Infrastructure.Enumerations.MarketType>();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> @__Expr0Get() {
                
                #line 65 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
          new List<Infrastructure.Enumerations.MarketType>();
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 380 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.PerfilUsuario>> expression = () => 
          iu.Perfil;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.PerfilUsuario @__Expr1Get() {
                
                #line 380 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
          iu.Perfil;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.PerfilUsuario ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 81 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                  Business.Usuario.ObtenerCuentasOrdenantes(iu, strIdUser, "", "");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr2Get() {
                
                #line 81 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                  Business.Usuario.ObtenerCuentasOrdenantes(iu, strIdUser, "", "");
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 88 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                  IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr4Get() {
                
                #line 88 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                  IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 99 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>> expression = () => 
                        Business.Usuario.FillClientUser(dtClientes);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> @__Expr5Get() {
                
                #line 99 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                        Business.Usuario.FillClientUser(dtClientes);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 113 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            Business.PuntasProfundidad.ObtenerNumPuntasAMostrar(iu, strIdUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr7Get() {
                
                #line 113 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                            Business.PuntasProfundidad.ObtenerNumPuntasAMostrar(iu, strIdUser);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 128 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                  Business.Usuario.ObtenerUltimoIngreso(strIdUser, strIpAddress);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr9Get() {
                
                #line 128 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                  Business.Usuario.ObtenerUltimoIngreso(strIdUser, strIpAddress);
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 140 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client>>> expression = () => 
                                  Clients;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client> @__Expr11Get() {
                
                #line 140 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                  Clients;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client> ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 152 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  iu.IsCertified;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr13Get() {
                
                #line 152 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                  iu.IsCertified;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 168 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      iu.Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr15Get() {
                
                #line 168 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                      iu.Id;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 180 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Enumerations.PerfilUsuario>> expression = () => 
                                      Dataifx.Trading.Business.Converter.ConvertProfile.ObtenerPerfil(iu.Perfil);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Enumerations.PerfilUsuario @__Expr17Get() {
                
                #line 180 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                      Dataifx.Trading.Business.Converter.ConvertProfile.ObtenerPerfil(iu.Perfil);
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Enumerations.PerfilUsuario ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 192 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      iu.InfoClave.ClaveInicial.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr19Get() {
                
                #line 192 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                      iu.InfoClave.ClaveInicial.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 204 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      iu.UsuarioSoporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr21Get() {
                
                #line 204 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                      iu.UsuarioSoporte;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 220 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                          iu.InfoClave.DiasRestantesExpiracionClave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr23Get() {
                
                #line 220 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                          iu.InfoClave.DiasRestantesExpiracionClave;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 232 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          iu.Nombre + " " + iu.Apellidos;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr25Get() {
                
                #line 232 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                          iu.Nombre + " " + iu.Apellidos;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 264 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          string.Empty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr29Get() {
                
                #line 264 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                          string.Empty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 279 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>> expression = () => 
                                            ListMarket.ToList();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Enumerations.MarketType> @__Expr31Get() {
                
                #line 279 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                            ListMarket.ToList();
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Enumerations.MarketType> ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 303 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>> expression = () => 
                        Business.Correval.User.GetAccountClientes(strIdUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> @__Expr33Get() {
                
                #line 303 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                        Business.Correval.User.GetAccountClientes(strIdUser);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 317 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>> expression = () => 
                            (List<Infrastructure.Enumerations.MarketType>)Business.Correval.User.ConsultarTipoMercado(strIdUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> @__Expr35Get() {
                
                #line 317 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                            (List<Infrastructure.Enumerations.MarketType>)Business.Correval.User.ConsultarTipoMercado(strIdUser);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 331 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                Business.Correval.BidsOffers.ObtenerNumPuntasAMostrar(iu, Convert.ToDecimal(iu.InfoCliente.Id));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr37Get() {
                
                #line 331 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                Business.Correval.BidsOffers.ObtenerNumPuntasAMostrar(iu, Convert.ToDecimal(iu.InfoCliente.Id));
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 346 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                      Business.Usuario.ObtenerUltimoIngreso(strIdUser, strIpAddress);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr39Get() {
                
                #line 346 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                      Business.Usuario.ObtenerUltimoIngreso(strIdUser, strIpAddress);
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 358 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client>>> expression = () => 
                                      Clients;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client> @__Expr41Get() {
                
                #line 358 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                                      Clients;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IEnumerable<Dataifx.Trading.Infrastructure.Models.Client> ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 401 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
            IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr43Get() {
                
                #line 401 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
            IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 461 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>> expression = () => 
                  Business.Usuario.GetAccountClientsByTrader(iu.InfoCliente.Id);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> @__Expr44Get() {
                
                #line 461 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                  Business.Usuario.GetAccountClientsByTrader(iu.InfoCliente.Id);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 475 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      Business.PuntasProfundidad.ObtenerNumPuntasAMostrarOtros(iu,iu.Id);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr46Get() {
                
                #line 475 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                      Business.PuntasProfundidad.ObtenerNumPuntasAMostrarOtros(iu,iu.Id);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 412 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>>> expression = () => 
                  Business.Correval.User.GetAccountClientesByTrader(iu.InfoCliente.Id);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> @__Expr48Get() {
                
                #line 412 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                  Business.Correval.User.GetAccountClientesByTrader(iu.InfoCliente.Id);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client> ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 426 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>> expression = () => 
                      Business.Correval.User.ConsultarTipoMercadoComercial(iu.InfoCliente.Id);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> @__Expr50Get() {
                
                #line 426 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                      Business.Correval.User.ConsultarTipoMercadoComercial(iu.InfoCliente.Id);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType> ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 440 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                          Business.Correval.BidsOffers.ObtenerNumPuntasAMostrarOtros(iu, iu.Id);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr52Get() {
                
                #line 440 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                          Business.Correval.BidsOffers.ObtenerNumPuntasAMostrarOtros(iu, iu.Id);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 391 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                Business.Usuario.ObtenerCuentasOrdenantesIns(iu, strIdUser, "", "");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr54Get() {
                
                #line 391 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ORIGINATORACTIVITY.XAML"
                return 
                Business.Usuario.ObtenerCuentasOrdenantesIns(iu, strIdUser, "", "");
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
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
                if (((locationReferences[(offset + 5)].Name != "dtClientes") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Clients") 
                            || (locationReferences[(offset + 6)].Type != typeof(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Models.Client>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "ListMarket") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.Collections.Generic.IList<Dataifx.Trading.Infrastructure.Enumerations.MarketType>)))) {
                    return false;
                }
                return OriginatorActivity_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
