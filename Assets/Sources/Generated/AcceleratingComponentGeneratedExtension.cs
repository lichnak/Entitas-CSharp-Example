//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public partial class Entity {

        static readonly AcceleratingComponent acceleratingComponent = new AcceleratingComponent();

        public bool isAccelerating {
            get { return HasComponent(GameComponentIds.Accelerating); }
            set {
                if(value != isAccelerating) {
                    if(value) {
                        AddComponent(GameComponentIds.Accelerating, acceleratingComponent);
                    } else {
                        RemoveComponent(GameComponentIds.Accelerating);
                    }
                }
            }
        }

        public Entity IsAccelerating(bool value) {
            isAccelerating = value;
            return this;
        }
    }

    public partial class Context {

        public Entity acceleratingEntity { get { return GetGroup(GameMatcher.Accelerating).GetSingleEntity(); } }

        public bool isAccelerating {
            get { return acceleratingEntity != null; }
            set {
                var entity = acceleratingEntity;
                if(value != (entity != null)) {
                    if(value) {
                        CreateEntity().isAccelerating = true;
                    } else {
                        DestroyEntity(entity);
                    }
                }
            }
        }
    }
}

    public partial class GameMatcher {

        static IMatcher _matcherAccelerating;

        public static IMatcher Accelerating {
            get {
                if(_matcherAccelerating == null) {
                    var matcher = (Matcher)Matcher.AllOf(GameComponentIds.Accelerating);
                    matcher.componentNames = GameComponentIds.componentNames;
                    _matcherAccelerating = matcher;
                }

                return _matcherAccelerating;
            }
        }
    }
