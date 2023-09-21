# 🎮Game Diagram Flow


## 🪴PlantUML code for generate Diagram

```uml
@startuml
 (*) --> "PlayerSite"
 "PlayerSite" --> "Coloris"
 "Coloris" --> "Yog"
 "Yog" -right-> "Deduct"
 "Yog" -right-> "Cancel"
 "Yog" -right-> "Rollback"
 "Yog" -right-> "Settle"
 "Yog" -right-> "Running"
 "Yog" --> "Utopia"
 "Yog" --> "Triton"
@enduml
```


## 👨‍💻Output From Code Above

![App Screenshot](http://www.plantuml.com/plantuml/dpng/RSl12i8m383X-vwYzAH2Nq46ym74wS5ZxK8DPebqwS6tbp141Zqb-J_IBngBrfcwtM7lGZWwVwRuWJAYWkysryg3a1HSp7xh2dV95csuK30_rUe9ffgq0KFa1DI0Yn0zOderQ0HLWjPFPKREVx5uKtbZtBPhGHNsNGyyrPc-)


## Definition

- Commission Stack : the commission that player will get based on the stack that player put in the game to play.

