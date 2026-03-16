<?php
session_start();
require_once 'db.php';

// Sécurité : on vérifie que l'élève est connecté
if (!isset($_SESSION['user'])) {
    header('Location: login.php');
    exit();
}

$id_quiz = isset($_GET['id']) ? intval($_GET['id']) : 0;

// On récupère TOUTES les questions de ce QCM 
$query = $pdo->prepare("SELECT * FROM question WHERE id_questionnaire = :idQ");
$query->execute(['idQ' => $id_quiz]);
$questions = $query->fetchAll();

$message = "";
$score = 0;
$total = count($questions);
$deja_repondu = false;

// Le calcul du score quand on valide
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $deja_repondu = true;
    
    foreach ($questions as $q) {
        $id_q = $q['id'];
        if (isset($_POST['reponse'][$id_q])) {
            $rep_user = intval($_POST['reponse'][$id_q]);
            // On compare avec 'reponse_vrai'
            if ($rep_user === intval($q['reponse_vrai'])) {
                $score++;
            }
        }
    }
    
    // Affichage du score
    $couleur = ($score == $total) ? '#2ecc71' : '#f39c12';
    $message = "<div style='background-color: $couleur; color: white; padding: 20px; text-align: center; border-radius: 8px; font-weight: bold; font-size: 1.5em; margin-bottom: 20px;'>
                    🎉 Ton Score : $score / $total
                </div>";
}
?>

<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <title>Répondre au Quiz - Stadium</title>
    <style>
        body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; background-color: #f4f7f6; margin: 0; padding: 0; }
        header { background-color: #2c3e50; color: white; padding: 20px; text-align: center; }
        .container { max-width: 600px; margin: 40px auto; background: white; padding: 30px; border-radius: 8px; box-shadow: 0 4px 15px rgba(0,0,0,0.1); }
        .question-box { margin-bottom: 25px; padding: 20px; background-color: #f9f9f9; border-left: 5px solid #3498db; border-radius: 4px; }
        .question-text { font-size: 1.2em; font-weight: bold; margin-bottom: 15px; color: #2c3e50; }
        .radio-label { font-size: 1.1em; cursor: pointer; margin-right: 20px; }
        .btn-valider { background-color: #3498db; color: white; border: none; padding: 15px; width: 100%; font-size: 1.2em; border-radius: 5px; cursor: pointer; font-weight: bold; transition: 0.3s; }
        .btn-valider:hover { background-color: #2980b9; }
        .btn-retour { display: block; text-align: center; margin-top: 20px; color: #7f8c8d; text-decoration: none; font-weight: bold; }
        .btn-retour:hover { color: #2c3e50; }
    </style>
</head>
<body>
    <header>
        <h1>🏟️ Session de Quiz</h1>
    </header>

    <div class="container">
        <?php echo $message; ?>

        <?php if (!$deja_repondu && $total > 0): ?>
            <form method="POST">
                <?php foreach ($questions as $index => $q): ?>
                    <div class="question-box">
                        <div class="question-text">
                            Question <?php echo ($index + 1); ?> : <?php echo htmlspecialchars($q['libelle']); ?>
                        </div>
                        <label class="radio-label">
                            <input type="radio" name="reponse[<?php echo $q['id']; ?>]" value="1" required> Vrai ✅
                        </label>
                        <label class="radio-label">
                            <input type="radio" name="reponse[<?php echo $q['id']; ?>]" value="0" required> Faux ❌
                        </label>
                    </div>
                <?php endforeach; ?>
                <button type="submit" class="btn-valider">Valider mes réponses</button>
            </form>
        <?php elseif ($total == 0): ?>
            <p style="text-align: center; font-size: 1.2em; color: #e74c3c;">Aucune question n'a encore été ajoutée à ce questionnaire.</p>
        <?php endif; ?>

        <a href="index.php" class="btn-retour">🔙 Retour à la liste des QCM</a>
    </div>
</body>
</html>