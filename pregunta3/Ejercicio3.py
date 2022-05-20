# -*- coding: utf-8 -*-
"""
Created on Tue Apr 19 17:42:33 2022

@author: 56946
"""

from pyswip import Prolog
prolog = Prolog()

prolog.assertz("abuelo(juan,maria)")
prolog.assertz("abuelo(juan,julio)")
prolog.assertz("nieto(maria,juan)")
prolog.assertz("nieto(julio,juan)")
prolog.assertz("es_primo(maria,rene)")
prolog.assertz("es_primo(maria,julio)")

#list(prolog.query("padre(juan,X)"))==[{"X":"maria"},{"Y":"julio"}]

for elemento in prolog.query("abuelo(X,Y)"):
    print(elemento["X"],"es abuelo de ",elemento["Y"])
for elemento in prolog.query("nieto(X,Y)"):
    print(elemento["X"],"es nieto de ",elemento["Y"])
for elemento in prolog.query("es_primo(X,Y)"):
    print(elemento["X"],"es primo de ",elemento["Y"])