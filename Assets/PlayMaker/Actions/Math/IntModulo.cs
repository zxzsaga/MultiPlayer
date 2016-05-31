using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory(ActionCategory.Math)]
    [Tooltip("An Integer Variable Modulos a value.")]
    public class IntModulo : FsmStateAction
    {
        [RequiredField]
        [UIHint(UIHint.Variable)]
        public FsmInt intVariable;
        [RequiredField]
        public FsmInt modulo;

    	// Code that runs on entering the state.
    	public override void OnEnter()
    	{
            intVariable.Value %= modulo.Value;
    		Finish();
    	}
    }
}
