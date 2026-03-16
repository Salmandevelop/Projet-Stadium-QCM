<?php
session_start();
require_once 'db.php';

if (!empty($_POST)) {
    $pseudo = $_POST['pseudo'];
    $mdp = $_POST['mdp'];

    $sql = "SELECT * FROM utilisateur WHERE pseudo = :p AND mdp = :m";         // création session si non existant.
    $stmt = $pdo->prepare($sql);
    $stmt->execute(['p' => $pseudo, 'm' => $mdp]);
    $user = $stmt->fetch();

    if ($user) {        // si existe deja
        $_SESSION['user'] = $user['pseudo'];
        header('Location: index.php');
    } else {
        $erreur = "Identifiants incorrects !";
    }
}
?>
<!DOCTYPE html>
<html>
<head>
    <title>Login - Stadium</title>
    <style>
        body { font-family: sans-serif; background: #2c3e50; color: white; display: flex; justify-content: center; align-items: center; height: 100vh; }
        .login-box { background: white; color: #333; padding: 30px; border-radius: 8px; width: 300px; }
        input { width: 90%; padding: 10px; margin: 10px 0; }
        button { background: #3498db; color: white; border: none; padding: 10px; width: 100%; cursor: pointer; }


        
    </style>
</head>
<body>
    <div class="login-box">
        <h2>Connexion</h2>
        <?php if(isset($erreur)) echo "<p style='color:red'>$erreur</p>"; ?>
        <form method="POST">
            <input type="text" name="pseudo" placeholder="Pseudo" required>
            <input type="password" name="mdp" placeholder="Mot de passe" required>
            <button type="submit">Se connecter</button>
        </form>
        <p style="margin-top: 15px; text-align: center;">
    Pas encore de compte ? <a href="inscription.php" style="color: #3498db;">S'inscrire ici</a>
</p>
    </div>
</body>
</html>