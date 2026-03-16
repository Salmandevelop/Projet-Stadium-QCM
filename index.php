<?php 

session_start();
if (!isset($_SESSION['user'])) {
    header('Location: login.php');
    exit();
}

require_once 'db.php'; 

$query = $pdo->query("SELECT q.id as q_id, q.nom as q_nom, t.nom as t_nom, q.nb_question 
                      FROM questionnaire q 
                      INNER JOIN theme t ON q.id_theme = t.id");
$questionnaires = $query->fetchAll();
?>

<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Stadium Questionnaire - Front Office</title>
    <style>
        body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; background-color: #f4f7f6; margin: 0; padding: 0; }
        header { background-color: #2c3e50; color: white; padding: 20px; text-align: center; }
        .container { max-width: 800px; margin: 40px auto; background: white; padding: 20px; border-radius: 8px; box-shadow: 0 4px 8px rgba(0,0,0,0.1); }
        h2 { color: #34495e; border-bottom: 2px solid #3498db; padding-bottom: 10px; }
        .quiz-card { border: 1px solid #ddd; padding: 15px; margin-bottom: 15px; border-radius: 5px; display: flex; justify-content: space-between; align-items: center; }
        .quiz-card:hover { background-color: #f9f9f9; border-color: #3498db; }
        .btn { background-color: #3498db; color: white; border: none; padding: 10px 15px; border-radius: 5px; cursor: pointer; text-decoration: none; font-weight: bold; }
        .btn:hover { background-color: #2980b9; }
    </style>
</head>
<body>

    <header>
    <div style="float: right; display: flex; align-items: center; gap: 10px;">
        <a href="creer_quiz.php" class="btn" style="background-color: #e67e22; padding: 10px; text-decoration: none; border-radius: 5px;">➕ Créer un Quiz</a>
        
        <span style="margin-right: 10px;">Bienvenue, <?php echo $_SESSION['user']; ?> !</span>
        
        <a href="logout.php" class="btn" style="background-color: #e74c3c; padding: 10px; text-decoration: none; border-radius: 5px;">Déconnexion 🚪</a>
    </div>

    <h1>🏟️ Stadium Questionnaire</h1>
    <p>Bienvenue sur la plateforme de QCM (Front-Office)</p>
</header>

    <div class="container">
        <h2>Vos Questionnaires Disponibles</h2>
        
        <?php if(empty($questionnaires)): ?>
            <p>Aucun questionnaire n'est disponible pour le moment.</p>
        <?php else: ?>
            <?php foreach($questionnaires as $q): ?>
            <div class="quiz-card">
                <div>
                    <h3>Thème : <?php echo htmlspecialchars($q['t_nom']); ?></h3>
                    <p>Questionnaire : <?php echo htmlspecialchars($q['q_nom']); ?></p>
                    <p><?php echo htmlspecialchars($q['nb_question']); ?> Questions</p>
                </div>
                <a href="repondre.php?id=<?php echo $q['q_id']; ?>" class="btn">Lancer le Quiz 🚀</a>            
            </div>
            <?php endforeach; ?>
        <?php endif; ?>
    </div>

</body>
</html>