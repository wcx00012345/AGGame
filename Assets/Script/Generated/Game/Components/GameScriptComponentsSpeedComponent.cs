//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Script.Components.SpeedComponent scriptComponentsSpeed { get { return (Script.Components.SpeedComponent)GetComponent(GameComponentsLookup.ScriptComponentsSpeed); } }
    public bool hasScriptComponentsSpeed { get { return HasComponent(GameComponentsLookup.ScriptComponentsSpeed); } }

    public void AddScriptComponentsSpeed(UnityEngine.Vector2 newSpeed) {
        var index = GameComponentsLookup.ScriptComponentsSpeed;
        var component = (Script.Components.SpeedComponent)CreateComponent(index, typeof(Script.Components.SpeedComponent));
        component.Speed = newSpeed;
        AddComponent(index, component);
    }

    public void ReplaceScriptComponentsSpeed(UnityEngine.Vector2 newSpeed) {
        var index = GameComponentsLookup.ScriptComponentsSpeed;
        var component = (Script.Components.SpeedComponent)CreateComponent(index, typeof(Script.Components.SpeedComponent));
        component.Speed = newSpeed;
        ReplaceComponent(index, component);
    }

    public void RemoveScriptComponentsSpeed() {
        RemoveComponent(GameComponentsLookup.ScriptComponentsSpeed);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherScriptComponentsSpeed;

    public static Entitas.IMatcher<GameEntity> ScriptComponentsSpeed {
        get {
            if (_matcherScriptComponentsSpeed == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ScriptComponentsSpeed);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherScriptComponentsSpeed = matcher;
            }

            return _matcherScriptComponentsSpeed;
        }
    }
}
