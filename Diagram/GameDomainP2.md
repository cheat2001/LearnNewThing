# 🎮Game Relationship Diagram and Definition


## 🪴UML Code For Root Account Games Relationship

```uml
@startuml
 (*) --> "Root"
 "Root" --> "AllAPIGameProviders"
 "AllAPIGameProviders" --> "AllGameProviders"
 "AllAPIGameProviders" --> "GameProviderWhiteList"
 "AllGameProviders" --> "AllGames"
 "GameProviderWhiteList" --> "AllGames"
@enduml
```


## 👨‍💻Output From Code Above

![App Screenshot](http://www.plantuml.com/plantuml/png/SoWkIImgAStDuLBGqD9KqDMrKr0AoiylKUA2qX0XnvmSnm1FzyJSr82Y_BBCbDIYOYKkhC883IIeHXOBpyWiIVN9B2w1Qi5ZEj1K77enr3cavgK0VGa0)

## 🪴UML Code For Company Account Games Relationship

```uml
@startuml
 (*) --> "Company"
 "Company" --> "CompanyAPIGameProviders"
 "CompanyAPIGameProviders" --> "CompanyGameProviders (default disabled)"
 "CompanyGameProviders (default disabled)" --> "CompanyGames (default enabled)"
@enduml
```


## 👨‍💻Output From Code Above

![App Screenshot](http://www.plantuml.com/plantuml/png/SoWkIImgAStDuLBGqD9KqDMrKr1opiyjICohLE92C54a70CytHDpKmEAyiioKrABYk4ACQLGDQ98AMYafAObbkQKAAHa5YScvQIcQ2fn4QqKqs0aLQbvCFCSKlDIW9u30000)


## Definition
