//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Script.Components.LifeComponent scriptComponentsLife { get { return (Script.Components.LifeComponent)GetComponent(GameComponentsLookup.ScriptComponentsLife); } }
    public bool hasScriptComponentsLife { get { return HasComponent(GameComponentsLookup.ScriptComponentsLife); } }

    public void AddScriptComponentsLife(float newTime) {
        var index = GameComponentsLookup.ScriptComponentsLife;
        var component = (Script.Components.LifeComponent)CreateComponent(index, typeof(Script.Components.LifeComponent));
        component.Time = newTime;
        AddComponent(index, component);
    }

    public void ReplaceScriptComponentsLife(float newTime) {
        var index = GameComponentsLookup.ScriptComponentsLife;
        var component = (Script.Components.LifeComponent)CreateComponent(index, typeof(Script.Components.LifeComponent));
        component.Time = newTime;
        ReplaceComponent(index, component);
    }

    public void RemoveScriptComponentsLife() {
        RemoveComponent(GameComponentsLookup.ScriptComponentsLife);
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

    static Entitas.IMatcher<GameEntity> _matcherScriptComponentsLife;

    public static Entitas.IMatcher<GameEntity> ScriptComponentsLife {
        get {
            if (_matcherScriptComponentsLife == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ScriptComponentsLife);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherScriptComponentsLife = matcher;
            }

            return _matcherScriptComponentsLife;
        }
    }
}
