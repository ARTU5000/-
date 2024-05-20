const vaultDwellerController = require('../controllers/vaultDwellerController');

module.exports = (app) => {
    app.post ('/api/vaultdweller/create', vaultDwellerController.register);
}