using System.Collections.Generic;

namespace Platform.Setters
{
    public static class SetterExtensions
    {
        public static TDecision SetFirstFromFirstListAndReturnTrue<TResult, TDecision>(this Setter<TResult, TDecision> setter, IList<TResult> list1, IList<TResult> list2)
        {
            setter.Set(list1[0]);
            return setter.TrueValue;
        }

        public static TDecision SetSecondFromFirstListAndReturnTrue<TResult, TDecision>(this Setter<TResult, TDecision> setter, IList<TResult> list1, IList<TResult> list2)
        {
            setter.Set(list1[1]);
            return setter.TrueValue;
        }

        public static TDecision SetFirstFromSecondListAndReturnTrue<TResult, TDecision>(this Setter<TResult, TDecision> setter, IList<TResult> list1, IList<TResult> list2)
        {
            setter.Set(list1[1]);
            return setter.TrueValue;
        }
    }
}

