const vaultDwellerController = require('../controllers/vaultDwellerController');

module.exports = (app) => {
    app.post ('/api/vaultdweller/create', vaultDwellerController.register);
    app.post ('/api/vaultdweller/getDweller', vaultDwellerController.getDweller);
    app.get ('/api/vaultdweller/getAllDwellers', vaultDwellerController.getAllDwellers);
    app.put('/api/vaultdweller/update', vaultDwellerController.updateDweller);
}