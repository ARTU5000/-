const VaultDweller = require('../models/vault_dweller');

module.exports = {
    register (req, res){
        const vault_dweller = req.body; //La captura de datos del morador
        VaultDweller.create(vault_dweller, (err, data)=>{
            if (err){
                return res.status(501).json({
                    success: false,
                    message: 'Fallo la creacion del morador',
                    error: err
                })
            }

            return res.status(201).json({
                succses: true,
                message: 'todo salio bien',
                data: data
            });
        });
    }
}