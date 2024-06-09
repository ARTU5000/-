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
    },

    getDweller(req, res)
    {
        const vault_dweller = req.body; //La captura de datos del morador
        VaultDweller.getDweller(vault_dweller, (err, data)=>{
            if (err){
                return res.status(501).json({
                    success: false,
                    message: 'aqui toy',
                    error: err
                })
            }

            return res.status(201).json({
                succses: true,
                message: 'todo salio bien',
                data: data
            });
        });
    },

    getAllDwellers(req, res)
    {
        const vault_dweller = req.body; //La captura de datos del morador
        VaultDweller.getAllDwellers(vault_dweller, (err, data)=>{
            if (err){
                return res.status(501).json({
                    success: false,
                    message: 'aqui toy',
                    error: err
                })
            }

            return res.status(201).json({
                succses: true,
                message: 'todo salio bien',
                data: data
            });
        });
    },

    updateDweller(req, res) {
        const vault_dweller = req.body; // La captura de datos del morador
        VaultDweller.update(vault_dweller, (err, data) => {
            if (err) {
                if (err.kind === "not_found") {
                    return res.status(404).json({
                        success: false,
                        message: `No se encontró el morador con id ${vault_dweller.id}.`
                    });
                } else {
                    return res.status(501).json({
                        success: false,
                        message: 'Error al actualizar el morador',
                        error: err
                    });
                }
            }

            return res.status(200).json({
                success: true,
                message: 'Morador actualizado exitosamente',
                data: data
            });
        });
    }
}
