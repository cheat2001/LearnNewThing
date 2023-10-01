# 🎮Game Relationship Diagram and Definition

## 📑Definition

* **AllAPIGameProviders**: It's like an aggregator that contains many game providers.
* **AllGameProvider**: One GameProvider contains many games.
* **AllGames**: It will store all of the games that map with Game Provider ID.
* **CompanyAPIGameProviders**: This table will be stored the AllAPIGameProviders that map with a specific webId(company).
* **CompanyGameProviders**: This table will record the data about gameProvider that each company exists.
* **CompanyGames**: in this table, we store any game that is enabled with the specific company.
* **GameProviderWhiteList**: This table will record the game provider with a specific company, even though the game provider in the root account is disabled, and the company that has webId in here still displays that game provider.

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
