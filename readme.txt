chechkout schimba pe alt branc

modificarile de pe un branch anume care nu is puse pe maste
-trebuie duse toate branchurile de pe origin la tine
-



cum faci commit

- click dreapta git -> commit, poti scrie in cmd git commit sau commit din visual studio

dupoa comit, push
-- fie push dupa git->cmommit
sau click dreapta - push
===de pe local->origin master

dupa mergi pe github, pe branch si new pull request

cineva rezolva pull req, nu eu, se vde in tab de https://github.com/Fedal/StoreProj/pulls


dupa rezolvare req, cum isi aduce el moduficarile pe masterul lui
--- se schimba branch local pe master local, am verificat git branch si dupa checkout la master
- am facut git pull pt a aduce toate modificarile de pe origin master pe masterul local
- dupa ce le-am adus pe masterul local ne-am mutat pe branch main_dev(branch pe care lucram) si am facut REBASE(se face din tortoisegit) in stanga va fi branch main_dev iar in dreapta va fi upstring catre cine se va face rebase master (simplu)

dupa ce s-a facut rebase, daca a fost fast forward se poate face push pe branch fara nicio problema
altfel,  daca apar commit-uri, se face push cu unknown changes (casuta selectata)