Ext.namespace('Maer.paneles.general');

Maer.paneles.general.Empleados = Ext.extend(Maer.ux.browser.Panel, {
    cargarDirectFn: Empleados.Get,
    guardarDirectFn: Empleados.Guardar,
    layout: 'form',
    maximized: false,
    fondoGris: true,

    getExtraDataCallbackMsg: function (o) { return 'Empleados ' + o; },

    initComponent: function () {

        var panel = this;

        this.txtNombre = new Ext.form.TextField({
            fieldLabel: 'Nombre',
            allowBlank: false
        });
        this.txtApellido = new Ext.form.TextField({
            fieldLabel: 'Apellido',
            allowBlank: false
        });

        this.txtGenero = new Ext.form.TextField({
            fieldLabel: 'Genero',
            allowBlank: false
        });

        this.txtFechaNacimiento = new Ext.form.TextField({
            fieldLabel: 'FechaNacimiento  ',
            allowBlank: false
        });

        this.txtNumeroInterno = new Ext.form.TextField({
            fieldLabel: 'NumeroInterno ',
            allowBlank: false
        });



        this.txtObservacion = new Ext.form.TextField({
            fieldLabel: 'Observacion',
            allowBlank: false
        });


        this.txtEmpresaId = new Ext.form.TextField({
            fieldLabel: 'EmpresaId ',
            allowBlank: false
        });

        this.txtOficinaId = new Ext.form.TextField({
            fieldLabel: 'OficinaId ',
            allowBlank: false
        });


        var config = {
            items: [panelSuperior, this.grid],
            width: 500,
            height: 400,

            // MANEJO DE TECLADO POR PANEL
            keys: [{
                key: Ext.EventObject.F2,
                fn: this.guardar,
                scope: this,
                stopEvent: true
            }, {
                key: Ext.EventObject.DELETE,
                ctrl: true,
                fn: this.grid.deleteRow,
                scope: this.grid,
                stopEvent: true
            }, {
                key: Ext.EventObject.INSERT,
                ctrl: true,
                fn: this.grid.addRow,
                scope: this.grid,
                stopEvent: true
            }]

        };

        Ext.apply(this, Ext.apply(this.initialConfig, config));
        Maer.paneles.general.Empleados.superclass.initComponent.apply(this, arguments);
    },
   
    init: function () {
        this.refrescarComponentesPorEmpresa();
    },
    
 
});