# Système de Gestion de Transactions Financières avec Règles Personnalisées

Ce projet est une application console C# qui permet de gérer des transactions financières comme les dépôts et les retraits, avec des règles de validation personnalisées appliquées à chaque type de transaction. Le programme permet d'ajouter de nouvelles règles et types de transactions.Table des matières

<h1>Table des matières</h1>
<ol>
  	  <li>Prérequis <ul>
      	  <li>Installation</li>
	  <li>Utilisation</li>
</ol>

Installation

Clonez le dépôt sur votre machine locale à l'aide de Git : 
	
 	git clone [https://github.com/votre-utilisateur/](https://github.com/KevinNadeau/Gestion-de-Transactions-Financi-res.git)

Restaurez les dépendances (si nécessaire) :
	
 	dotnet restore

Utilisation

Ouvrez le projet dans Visual Studio ou tout autre IDE compatible.
Exécutez le projet en utilisant Visual Studio ou la ligne de commande.
Si vous utilisez la ligne de commande :

	dotnet run

 Exemple de sortie :

L'application va traiter des transactions avec des règles personnalisées à tester dans le main de l'application. Voici un exemple de sortie attendue :

	Le dépôt dépasse le montant maximum autorisé.
 	refusé: Le montant du retrait dépasse votre solde disponible.
	échec de la transaction.
	transaction effectuée.
	
Le programme traite les transactions selon les règles définies. Dans cet exemple :

Un dépôt de 60 000 € échoue en raison de la limite maximale de dépôt (50 000 €).<br />
Un retrait de 900 € échoue car il dépasse le solde disponible.

