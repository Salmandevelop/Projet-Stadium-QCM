<?php
require_once 'db.php';

if (!empty($_POST)) {
    $pseudo = $_POST['pseudo'];
    $mdp = $_POST['mdp'];

    // pseudo et mdp seulement 
    $sql = "INSERT INTO utilisateur (pseudo, mdp) VALUES (:p, :m)";
    $stmt = $pdo->prepare($sql);
    
    try {
        $stmt->execute(['p' => $pseudo, 'm' => $mdp]);
        header('Location: login.php?success=1');
    } catch (Exception $e) {
        $erreur = "Ce pseudo est déjà utilisé !";
    }
}
?>
<!DOCTYPE html>
<html>
<head>
    <title>Inscription - Stadium</title>
    <style>
        body { font-family: sans-serif; background: #2c3e50; color: white; display: flex; justify-content: center; align-items: center; height: 100vh; }
        .login-box { background: white; color: #333; padding: 30px; border-radius: 8px; width: 300px; }
        input { width: 90%; padding: 10px; margin: 10px 0; }
        button { background: #2ecc71; color: white; border: none; padding: 10px; width: 100%; cursor: pointer; }
    </style>
</head>
<body>
    <div class="login-box">
        <h2>Créer un compte</h2>
        <?php if(isset($erreur)) echo "<p style='color:red'>$erreur</p>"; ?>
        <form method="POST">
            <input type="text" name="pseudo" placeholder="Votre Pseudo" required>
            <input type="password" name="mdp" placeholder="Votre Mot de passe" required>
            <button type="submit">S'inscrire</button>
        </form>
        <p style="margin-top: 15px; text-align: center;">
            Déjà inscrit ? <a href="login.php">Se connecter</a>
        </p>
    </div>
</body>
</html>