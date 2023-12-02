# Novalife Plugin PanelHelper v1.0.0

Ce plugin Novalife UIPanelMangager fournit des fonctionnalités facilitant la création d'interface lors du développement
Il s'agit d'une dépendance pour les plugins employant UIPanelManager.

## Table des Matières

- [Installation](#installation)
- [Utilisation](#utilisation)
- [Fonctionnalités](#fonctionnalités)
- [Droits de Propriété Intellectuelle](#droits-de-propriété-intellectuelle)

## Installation

1. Téléchargez le fichier `PanelHelper.dll` depuis la page des releases de ce dépôt.
2. Ajoutez le fichier `PanelHelper.dll` dans le dossier des plugins de votre serveur Novalife.

## Utilisation

Le Plugin UIPanelManager étend les fonctionnalités de Novalife pour faciliter l'ajout d'interfaces en jeu.
Pour l'utiliser, suivez ces étapes :

1. Intégrez le Plugin UIPanelManager.dll en tant que référence dans votre projet Novalife.
2. Vous n'avez plus qu'à utiliser les fonctionnalités fournies par UIPanelManager.

## Fonctionnalités

Voici un exemple minimal de création de panneau en utilisant UIPanelManager :

```csharp
// Changer de panel
PanelManager.NextPanel(player, ui, () => VotrePanel());

// Notifier un joueur
PanelManager.Notification(player, "Titre", "Votre message", NotificationManager.Type.Error);
PanelManager.Notification(player, "Titre", "Votre message", NotificationManager.Type.Warning);
PanelManager.Notification(player, "Titre", "Votre message", NotificationManager.Type.Info);
PanelManager.Notification(player, "Titre", "Votre message", NotificationManager.Type.Success);

// Fermer un Panel
panel.AddButton("Fermer", (ui) => PanelManager.Quit(ui, player));
```

## Droits de Propriété Intellectuelle

Je vous demande simplement de respecter le temps que j'ai mis dans ce plugin.
Merci de ne pas vous approprier le plugin, de ne pas le copier bêtement, et de ne pas faire des trucs étranges avec.

Pour discuter, contactez-moi sur discord: Aarnow
Serveur discord: https://discord.gg/8j2suEE9Mf