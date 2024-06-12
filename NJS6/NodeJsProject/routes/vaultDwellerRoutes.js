const vaultDwellerController = require('../controllers/vaultDwellerController');

module.exports = (app) => {
    app.post ('/api/vaultdweller/create', vaultDwellerController.register);
    app.post ('/api/vaultdweller/getDweller', vaultDwellerController.getDweller);
    app.get ('/api/vaultdweller/getAllDwellers', vaultDwellerController.getAllDwellers);
    app.post('/api/vaultdweller/CrearDatos', vaultDwellerController.Datos);
    app.put('/api/vaultdweller/SetDatos', vaultDwellerController.DatosCambio);
    app.post('/api/vaultdweller/GetDatos', vaultDwellerController.getDatos)
}